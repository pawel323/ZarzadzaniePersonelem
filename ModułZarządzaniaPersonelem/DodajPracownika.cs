using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Runtime.InteropServices;

namespace ModułZarządzaniaPersonelem
{
    internal partial class DodajPracownika : Form
    {
        Thread th;
        User user;
        public DodajPracownika()
        {
            InitializeComponent();
            this.user = user;

        }
        
        //Dodanie nowego pracownika do bazy danych
        private void buttonZapiszDodajPracownika_Click(object sender, EventArgs e)
        {
            if (textBoxImięDodajPracownika.Text != String.Empty &&
                textBoxNazwiskoDodajPracownika.Text != String.Empty &&
                textBoxLoginDodajPracownika.Text != String.Empty &&
                textBoxHasłoDodajPracownika.Text != String.Empty &&
                textBoxPotwierdzHaslo.Text != String.Empty &&
                textBoxKodDodajPracownika.Text != String.Empty &&
                numericUpDownPensjaDodajPracownika.Value > 0.00M &&
                numericUpDownStawkaDodajPracownika.Value > 0.00M &&
                comboBoxUprawnieniaDodajPracownika.SelectedItem != null)
            {
                if (textBoxHasłoDodajPracownika.Text == textBoxPotwierdzHaslo.Text && textBoxHasłoDodajPracownika.Text.Length > 6)
                {
                    User u = new User();

                    u.FirstName = textBoxImięDodajPracownika.Text;
                    u.LastName = textBoxNazwiskoDodajPracownika.Text;
                    u.Login = textBoxLoginDodajPracownika.Text;
                    u.PasswordHash = textBoxHasłoDodajPracownika.Text;
                    u.CodeHash = textBoxKodDodajPracownika.Text;  
                    u.BaseSalary = numericUpDownPensjaDodajPracownika.Value;
                    u.HourlyRate = numericUpDownStawkaDodajPracownika.Value;
                    u.Permission = Convert.ToString(comboBoxUprawnieniaDodajPracownika.SelectedItem);
                    
                    u.INSERTUSER(u.FirstName, u.LastName, u.Login, u.PasswordHash, u.CodeHash, u.BaseSalary, u.HourlyRate, u.Permission);
                    
                    textBoxImięDodajPracownika.Clear();
                    textBoxNazwiskoDodajPracownika.Clear();
                    textBoxHasłoDodajPracownika.Clear();
                    textBoxLoginDodajPracownika.Clear();
                    textBoxKodDodajPracownika.Clear();
                    textBoxPotwierdzHaslo.Clear();
                    numericUpDownPensjaDodajPracownika.Value = 0;
                    numericUpDownStawkaDodajPracownika.Value = 0;
                    comboBoxUprawnieniaDodajPracownika.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Hasła nie są takie same lub podane hasło jest za krótkie");
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij informacje");
            }
        }

        //Blokowanie znaków specjalnych
        private void textBoxImięDodajPracownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
                e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
                e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
                e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
                e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
                e.KeyChar == '>' || e.KeyChar == '?' || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' ||
               e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8'
               || e.KeyChar == '9' || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void textBoxNazwiskoDodajPracownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
                e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
                e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
                e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
                e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
                e.KeyChar == '>' || e.KeyChar == '?' || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' ||
               e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8'
               || e.KeyChar == '9' || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void textBoxLoginDodajPracownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
       e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
       e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
       e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
       e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
       e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
       e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
       e.KeyChar == '>' || e.KeyChar == '?' || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 'ą' || e.KeyChar == 'ę' || e.KeyChar == 'ś' || e.KeyChar == 'ł' || 
                e.KeyChar == 'ż' || e.KeyChar == 'ź' || e.KeyChar == 'ć' || e.KeyChar == 'ń' || e.KeyChar == 'ó' ||
                e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void textBoxHasłoDodajPracownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
       e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
       e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
       e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
       e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
       e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
       e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
       e.KeyChar == '>' || e.KeyChar == '?' || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 'ą' || e.KeyChar == 'ę' || e.KeyChar == 'ś' || e.KeyChar == 'ł' ||
                e.KeyChar == 'ż' || e.KeyChar == 'ź' || e.KeyChar == 'ć' || e.KeyChar == 'ń' || e.KeyChar == 'ó' ||
                e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void textBoxKodDodajPracownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
       e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
       e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
       e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
       e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
       e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
       e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
       e.KeyChar == '>' || e.KeyChar == '?' || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        //Blokowanie znaków specjalnych
        private void comboBoxUprawnieniaDodajPracownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' || e.KeyChar == '~' || e.KeyChar == '!' || e.KeyChar == '@' ||
                e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '^' ||
                e.KeyChar == '&' || e.KeyChar == '*' || e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '=' || e.KeyChar == '+' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == ']' ||
                e.KeyChar == '}' || e.KeyChar == '|' || e.KeyChar == ';' || e.KeyChar == ':' ||
                e.KeyChar == '"' || e.KeyChar == ',' || e.KeyChar == '<' || e.KeyChar == '.' ||
                e.KeyChar == '>' || e.KeyChar == '?' || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' ||
               e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8'
               || e.KeyChar == '9' || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        //Opuszczenie formularza DodajPracownika i przejście do PanelMenadżera
        private void buttonWróć_Click(object sender, EventArgs e)
        {
            this.Dispose();
            th = new Thread(openForm);
            th.Start();
        }

        void openForm()
        {
                Application.Run(new PanelMenadżera());
        }

        //Szyfrowanie hasła i potwierdzenia hasła
        private void checkBoxPokazHaslo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPokazHaslo.Checked == true)
            {
                textBoxHasłoDodajPracownika.PasswordChar = '\0';
                textBoxPotwierdzHaslo.PasswordChar = '\0';
            }
            else
            {
                textBoxHasłoDodajPracownika.PasswordChar = '*';
                textBoxPotwierdzHaslo.PasswordChar = '*';
            }
        }

        //Komunikat potwierdzający opuszczenie programu
        private void DodajPracownika_FormClosing(object sender, FormClosingEventArgs e)
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
