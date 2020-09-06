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
    public partial class WyświetlanieHarmonogramu : Form
    {
        Thread th;
        
        public WyświetlanieHarmonogramu()
        {
            InitializeComponent();
        }
        
        private void WyświetlanieHarmonogramu_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'modułZarządzaniaPersonelemDataSet.User' . Możesz go przenieść lub usunąć.
            this.userTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.User);
           

        }

        //Przypisanie odpowiedniego koloru wiersza w tabeli do statusu zadania
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells[1].Value) == "otwarte")
                {
                    row.DefaultCellStyle.BackColor = Color.Blue;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (Convert.ToString(row.Cells[1].Value) == "zamknięte")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (Convert.ToString(row.Cells[1].Value) == "odwołane")
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (Convert.ToString(row.Cells[1].Value) == "usunięte")
                {
                    row.DefaultCellStyle.BackColor = Color.Black;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        //Wyszukanie zadania dla konkretnego pracownika w konkretnym dniu
        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = false;
            dateTimePicker1.Enabled = false;
            dataGridView1.Rows.Clear();
            odczyt();
        }

        //Odczytanie z bazy danych opisu zadania, nazwy aktualnego statusu zadania i godziny rozpoczęcia zadania
        void odczyt()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sql = "set dateformat dmy select (select t.description from Task t where t.task_ID = s.task_ID ) as 'Opis zadania', " +
                "(select n.nameStatus from ScheduleStatus n where n.scheduleStatus_ID = s.scheduleStatus_ID) as 'Status zadania'," +
                " hourOfExecution as 'Godzina rozpoczęcia' from Schedule s where user_ID IN(select user_ID from[User] where firstName like @firstName  AND lastName like @lastName) " +
                "AND  dateSchedule between @dateSchedule AND @dateSchedule order by hourOfExecution ASC";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@lastName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@dateSchedule", dateTimePicker1.Value.ToShortDateString());
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        var a = (string)rdr[0];
                        var b = (string)rdr[1];
                        var c = (TimeSpan)rdr[2];
                        Schedule sch = new Schedule();
                        sch.Task_ID = a;
                        sch.ScheduleStatus_ID = b;
                        sch.HourOfExecution = c;
                        int row_index = dataGridView1.Rows.Add(sch.ToObjTbl);
                        dataGridView1.Rows[row_index].Tag = sch;
                    }
                    con.Close();
                    con.Dispose();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Niepowodzenie " + e.ToString());
                }
            }
        }

        //Powrót do formularza PanelMenadżera
        private void buttonWróć_Click(object sender, EventArgs e)
        {
            this.Dispose();
            th = new Thread(openForm);
            th.Start();
        }

        private void openForm()
        {
            Application.Run(new PanelMenadżera());
        }

        //Przejście do zmiany statusu wybranego zadania
        private void buttonModyfikuj_Click(object sender, EventArgs e)
        {
            Schedule sch = new Schedule();
            foreach (DataGridViewRow dgv in dataGridView1.SelectedRows)
            Modyfikacja();
        }

        //Wyszukanie ID zadania z tabeli Schedule na podstawie imienia i nazwiska pracownika, opisu zadania, daty i godziny wykonania
        void Modyfikacja()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                   
                        string sql = "set dateformat dmy select top 1 (schedule_ID) from Schedule where user_ID IN (select user_ID from [User] where firstName like @firstName AND lastName like @lastName) " +
                       "AND task_ID IN (select task_ID from Task where description like @description) AND dateSchedule = @dateSchedule AND scheduleStatus_ID IN (select scheduleStatus_ID from ScheduleStatus where nameStatus like @nameStatus) " +
                       "AND hourOfExecution between @hourOfExecution AND @hourOfExecution";

                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@lastName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@description", Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                        cmd.Parameters.AddWithValue("@dateSchedule", dateTimePicker1.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@nameStatus", Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));
                        string time = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                        cmd.Parameters.Add("@hourOfExecution", SqlDbType.Time).Value = TimeSpan.Parse(time);

                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        da.Fill(ds);

                        ModyfikacjaHarmonogramu mod = new ModyfikacjaHarmonogramu(ds);
                        if (mod.ShowDialog() != DialogResult.OK)
                            return;

                        this.Dispose();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Niepowodzenie " + e.ToString());
                }
            }

        }

        //Komunikat potwierdzający opuszczenie programu
        private void WyświetlanieHarmonogramu_FormClosing(object sender, FormClosingEventArgs e)
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

        //Zmiana filtrów wyszukiwania zadań
        private void buttonFiltrowanie_Click(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = true;
            dateTimePicker1.Enabled = true;
        }
    }
}
