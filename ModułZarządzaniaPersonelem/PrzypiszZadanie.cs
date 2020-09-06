using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;

namespace ModułZarządzaniaPersonelem
{
    public partial class PrzypiszZadanie : Form
    {
        Thread th;
        public PrzypiszZadanie()
        {
            InitializeComponent();

            refreshdata();
            refreshdata2();

        }
        
    

        private void PrzypiszZadanie_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'modułZarządzaniaPersonelemDataSet.ScheduleStatus' . Możesz go przenieść lub usunąć.
            this.scheduleStatusTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.ScheduleStatus);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'modułZarządzaniaPersonelemDataSet.Task' . Możesz go przenieść lub usunąć.
            this.taskTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.Task);
            this.userTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.User);
          
           
            dateTimePicker1.MinDate = DateTime.Now;       

            TimeToText1();
            TimeToText2();
        }

        //Sposób wyświetlania czasu
        void TimeToText1()
        {
            string a = Convert.ToString(numericUpDownGodzina.Value);


            if (numericUpDownGodzina.Value < 10)
            {
                string c = "0" + a;
                textBoxGodzina.Text = c;

            }
            else if (numericUpDownGodzina.Value >= 10)
            {
                textBoxGodzina.Text = a;
            }

        }

        //Sposób wyświetlania czasu
        void TimeToText2()
        {
            string b = Convert.ToString(numericUpDownMinuty.Value);


            if (numericUpDownMinuty.Value < 10)
            {
                string c = "0" + b;
                textBoxMinuty.Text = c;

            }
            else if (numericUpDownMinuty.Value >= 10)
            {
                textBoxMinuty.Text = b;
            }
        }

        //Sposób wyświetlania czasu
        private void numericUpDownGodzina_ValueChanged(object sender, EventArgs e)
        {
            TimeToText1();
        }

        //Sposób wyświetlania czasu
        private void numericUpDownMinuty_ValueChanged(object sender, EventArgs e)
        {
            TimeToText2();
        }

        //Przypisanie nowego zadania
        private void buttonPrzypiszZadanie_Click(object sender, EventArgs e)
        {
            if (textBoxImię.Text != string.Empty && textBoxNazwisko.Text != string.Empty && comboBoxOpisZadania.SelectedItem != null
                && comboBoxStatusZadania.SelectedItem != null)
            {
                var a = textBoxImię.Text;
                var b = textBoxNazwisko.Text;
                var c = comboBoxOpisZadania.SelectedItem.ToString();
                var d = dateTimePicker1.Value.ToShortDateString();
                var f = comboBoxStatusZadania.SelectedItem.ToString();
                var g = textBoxGodzina.Text;
                var h = textBoxMinuty.Text;
                Schedule sch = new Schedule();
                sch.ASSIGNTASK(a,b,c,d,f,g,h);
            }
            else
            {
                MessageBox.Show("Uzupełnij informacje");
            }
        
        }

        void refreshdata()
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Task", con);
                    SqlDataReader Sdr = cmd.ExecuteReader();
                    while (Sdr.Read())
                    {
                        Task schS = new Task();
                        schS.Description = (string)Sdr[2];
                        int cmb = comboBoxOpisZadania.Items.Add(schS.ToString());
                        comboBoxOpisZadania.SelectedItem = schS;
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
                        int cmb = comboBoxStatusZadania.Items.Add(schS.ToString());
                        comboBoxStatusZadania.SelectedItem = schS;
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

        //Powrót do formularza PanelMenadżera
        private void buttonWróc_Click(object sender, EventArgs e)
        {
            this.Dispose();
            th = new Thread(openForm);
            th.Start();
        }

        private void openForm()
        {
            Application.Run(new PanelMenadżera());
        }

        //Komunikat potwierdzający opuszczenie programu
        private void PrzypiszZadanie_FormClosing(object sender, FormClosingEventArgs e)
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

       
    }
}
