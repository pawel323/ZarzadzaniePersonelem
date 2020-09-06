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
using System.Diagnostics;

namespace ModułZarządzaniaPersonelem
{
    public partial class PanelMenadżera : Form
    {
        Task task;

        Thread th;

        public PanelMenadżera()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
        }

        //Zapisanie nowego zadania
        private void buttonZapiszZadanie_Click(object sender, EventArgs e)
        {

            if (textBoxNazwa.Text != string.Empty && textBoxOpis.Text != string.Empty)
            {
                var a = textBoxNazwa.Text;
                var b = textBoxOpis.Text;
                Task t = new Task(); 
                t.ADDTASK(a,b);
            }
            else
            {
                MessageBox.Show("Uzupełnij informacje");
            }

            //Odświeżenie tabeli do wyświetlania dostępnych zadań
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.taskTableAdapter.Update(this.modułZarządzaniaPersonelemDataSet.Task);
            this.taskTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.Task);
            textBoxNazwa.Clear();
            textBoxOpis.Clear();
            bindingNavigator1.Refresh();
        }

        //Przejście do formularza DodajPracownika
        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {

            this.Dispose();
            th = new Thread(openForm);
            th.Start();

        }

        private void openForm()
        {
                Application.Run(new DodajPracownika());
        }

        //Przejście do formularza EdycjaPracownika
        private void buttonEdytujPracownika_Click(object sender, EventArgs e)
        {

            this.Dispose();
            th = new Thread(openForm1);
            th.Start();

        }

        private void openForm1()
        {
            Application.Run(new EdycjaPracownika());
        }

        private void HarmonogramUprzywilejowany_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'modułZarządzaniaPersonelemDataSet.Task' . Możesz go przenieść lub usunąć.
            this.taskTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.Task);
           
            //Ustawienie aktualnej daty do wyświetlania
            DateTime n = DateTime.Now;
            labelData1.Text = (n.ToString("d"));

        }

        //Zatwierdzenie modyfikacji w istniejącym zadaniu
        private void buttonModyfikujZadanie_Click(object sender, EventArgs e)
        {
            if (textBoxIDZadania.Text != string.Empty && txtbNazwaZadania.Text != string.Empty && txtbOpisZadania.Text != string.Empty)
            {
                var a = Convert.ToInt32(textBoxIDZadania.Text);
                var b = txtbNazwaZadania.Text;
                var c = txtbOpisZadania.Text;
                Task t = new Task();
                t.UPDATE(b, c, a);
                //Odświeżenie tabeli do wyświetlania dostępnych zadań
                this.Validate();
                this.taskBindingSource.EndEdit();
                this.taskTableAdapter.Fill(this.modułZarządzaniaPersonelemDataSet.Task);
            }
            else
            {
                MessageBox.Show("Uzupełnij informacje");
                this.Dispose();
                th = new Thread(openForm5);
                th.Start();
            }

            
        }

        private void openForm5()
        {
            Application.Run(new PanelMenadżera());
        }

      
        //Blokowanie znaków specjalnych
        private void textBoxNazwa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
                e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
                e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
                e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
                e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
                e.KeyChar == '>' || e.KeyChar == '?' )
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void textBoxOpis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
                e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
                e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
                e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
                e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
                e.KeyChar == '>' || e.KeyChar == '?' )
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void txtbNazwaZadania_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
                e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
                e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
                e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
                e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
                e.KeyChar == '>' || e.KeyChar == '?' )
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void txtbOpisZadania_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
                e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
                e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
                e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
                e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
                e.KeyChar == '>' || e.KeyChar == '?' )
            {
                e.Handled = true;
            }
        }

        //Wylogowanie z programu
        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            this.Dispose();
            th = new Thread(openForm2);
            th.Start();
        }

        //Przejście do ekranu logowania
        private void openForm2()
        {
            Application.Run(new Logowanie());
        }

        //Przejście do formularza PrzypiszZadanie
        private void buttonPrzypisz_Click(object sender, EventArgs e)
        {
            this.Dispose();
            th = new Thread(openForm3);
            th.Start();
        }

        private void openForm3()
        {
            Application.Run(new PrzypiszZadanie());
        }

        //Przejście do formularza WyświetlanieHarmonogramu
        private void buttonWyświetl_Click(object sender, EventArgs e)
        {
            this.Dispose();
            th = new Thread(openForm4);
            th.Start();
        }

        private void openForm4()
        {
            Application.Run(new WyświetlanieHarmonogramu());
        }

        //Komunikat potwierdzający opuszczenie programu
        private void PanelMenadżera_FormClosing(object sender, FormClosingEventArgs e)
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