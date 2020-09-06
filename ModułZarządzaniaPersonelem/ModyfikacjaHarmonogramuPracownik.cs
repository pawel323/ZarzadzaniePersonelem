using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace ModułZarządzaniaPersonelem
{
    internal partial class ModyfikacjaHarmonogramuPracownik : Form
    {
        Thread th;
        
        public ModyfikacjaHarmonogramuPracownik(DataSet ds)
        {
            InitializeComponent();
            textBoxScheduleID.Text = ds.Tables[0].Rows[0]["schedule_ID"].ToString();
            refreshdata2();
        }

        private void ModyfikacjaHarmonogramuPracownik_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'modułZarządzaniaPersonelemDataSet.ScheduleStatus' . Możesz go przenieść lub usunąć.
            this.scheduleStatusTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.ScheduleStatus);
            Status();
        }

        //Określenie aktualnego statusu przypisanego zadania na podstawie ID
        void Status()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sql = "select nameStatus from ScheduleStatus where" +
                        " scheduleStatus_ID IN(select scheduleStatus_ID from " +
                        "Schedule where schedule_ID = @schedule_ID)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@schedule_ID", textBoxScheduleID.Text);
                    DataSet dss = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dss);
                    textBoxAktualnyStatus.Text = dss.Tables[0].Rows[0]["nameStatus"].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Niepowodzenie " + e.ToString());
                }
            }
        }

        //Zaktualizowanie statusu zadania
        private void buttonZaktualizuj_Click(object sender, EventArgs e)
        {
            if (comboBoxZaktualizujStatus.SelectedItem != null && textBoxAktualnyStatus.Text != comboBoxZaktualizujStatus.SelectedItem.ToString())
            {
                CheckPassword();
            }
            else
            {
                MessageBox.Show("Wybierz nowy status zadania");
            }
        }

        void refreshdata2()
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from ScheduleStatus", con);
                    SqlDataReader Sdr = cmd.ExecuteReader();
                    while (Sdr.Read())
                    {
                        ScheduleStatus schS = new ScheduleStatus();
                        schS.NameStatus = (string)Sdr[1];
                        int cmb = comboBoxZaktualizujStatus.Items.Add(schS.ToString());
                        comboBoxZaktualizujStatus.SelectedItem = schS;
                    }
                    Sdr.Close();
                    con.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Niepowodzenie " + e.ToString());
                }
            }
        }

        //Pobranie z bazy danych hasła pracownika, któremu przypisano modyfikowane zadanie
        void CheckPassword()
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    string sql = "select(select u.passwordHash from[User] u where u.user_ID = s.user_ID) as 'Hasło' from Schedule s where s.schedule_ID = @schedule_ID";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@schedule_ID", textBoxScheduleID.Text);

                    DataSet dsr = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dsr);

                    if (textBoxWpiszHaslo.Text == dsr.Tables[0].Rows[0]["Hasło"].ToString())
                    {
                        var a = Convert.ToString(comboBoxZaktualizujStatus.SelectedItem);
                        var b = textBoxScheduleID.Text;
                        Schedule sch = new Schedule();
                        sch.UPDATETASK(a,b);
                        DialogResult = DialogResult.OK;
                        this.Dispose();
                        th = new Thread(openForm);
                        th.Start();

                    }
                    else
                    {
                        MessageBox.Show("Podano nieprawidłowe hasło");
                        return;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Niepowodzenie " + e.ToString());
                }
            }
            
        }

        void openForm()
        {
            Application.Run(new HarmonogramNieuprzywilejowany());
        }

        //Komunikat potwierdzający opuszczenie programu
        private void ModyfikacjaHarmonogramuPracownik_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult res = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Zamykanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                {
                    if (res == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }

                }
            }
        }

        //Tymczasowe wyłączenie bądź włączenie szyfrowania hasła
        private void checkBoxPokazHaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPokazHaslo.Checked == true)
            {
                textBoxWpiszHaslo.PasswordChar = '\0';
            }
            else
            {
                textBoxWpiszHaslo.PasswordChar = '*';
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
