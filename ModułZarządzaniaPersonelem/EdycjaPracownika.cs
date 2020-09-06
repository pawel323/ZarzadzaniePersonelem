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
    internal partial class EdycjaPracownika : Form
    {
        Thread th;

        User user;
        public EdycjaPracownika()
        {
            InitializeComponent();
        }
        
        //Odświeżanie rekordów w tabeli
        public void RefreshDgv()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Tag == null)
                    continue;
                if (row.Tag.GetType() != typeof(User))
                    continue;

                User user = (User)row.Tag;

                for (int i = 0; i < row.Cells.Count; i++)
                    row.Cells[i].Value = user.ObjTbl[i];

            }          
        }

        private void EdycjaPracownika_Load(object sender, EventArgs e)
        {          
            odczyt();           
        }

        //Odczyt wszystkich użytkowników z bazy danych i wypisanie ich w tabelce
        void odczyt()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    con.Open();

                    string sql = "SELECT * FROM [User];";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var id = (int)rdr[0];
                        var a = (string)rdr[1];
                        var b = (string)rdr[2];
                        var c = (string)rdr[3];
                        var d = (string)rdr[4];
                        var e = (string)rdr[5];
                        var f = (decimal)rdr[6];
                        var g = (decimal)rdr[7];
                        var h = (string)rdr[8];
                        User user = new User();
                        user.User_Id = id;
                        user.FirstName = a;
                        user.LastName = b;
                        user.Login = c;
                        user.PasswordHash = d;
                        user.CodeHash = e;
                        user.BaseSalary = f;
                        user.HourlyRate = g;
                        user.Permission = h;
                        int row_index = dataGridView1.Rows.Add(user.ObjTbl);
                        dataGridView1.Rows[row_index].Tag = user;

                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Niepowodzenie");
                }
                con.Close();
            }


        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellDoubleClick_1(sender, e);
        }

        //Wybranie odpowiedniego pracownika z tabelki do modyfikacji jego danych
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            if (dataGridView1.SelectedRows[0].Tag == null)
                return;
            if (dataGridView1.SelectedRows[0].Tag.GetType() != typeof(User))
                return;
            User user = (User)dataGridView1.SelectedRows[0].Tag;
            ZmieńDanePracownika zmien = new ZmieńDanePracownika(user);
            if (zmien.ShowDialog() != DialogResult.OK)
                return;

           

            RefreshDgv();
           
            
            user.UPDATEUSER(user);

        }

        //Opuszczenie formularza EdycjaPracownika i przejście do PanelMenadżera
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

        //Odświeżanie tabelki
        private void buttonOdśwież_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            odczyt();
        }

        //Komunikat potwierdzający opuszczenie programu
        private void EdycjaPracownika_FormClosing(object sender, FormClosingEventArgs e)
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
