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
    internal partial class ZmieńDanePracownika : Form
    {
        Thread th;

        User user;

        public ZmieńDanePracownika(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        
        //Wypisanie informacji o pracowniku wybranym z tabelki w formularzu EdycjaPracownika
        private void ZmieńDanePracownika_Load(object sender, EventArgs e)
        {
            textBoxImięDodajPracownika.Text = user.FirstName;
            textBoxNazwiskoDodajPracownika.Text = user.LastName;
            textBoxHasłoDodajPracownika.Text = user.PasswordHash;
            textBoxLoginDodajPracownika.Text = user.Login;
            textBoxKodDodajPracownika.Text = user.CodeHash;
            numericUpDownPensjaDodajPracownika.Value = user.BaseSalary;
            numericUpDownStawkaDodajPracownika.Value = user.HourlyRate;
            comboBoxUprawnieniaDodajPracownika.SelectedItem = user.Permission;
            textBox1.Text = Convert.ToString(user.User_Id);
        }

        //Zatwierdzenie i przypisanie nowych informacji pracownikowi
        private void buttonZapiszDodajPracownika_Click(object sender, EventArgs e)
        {
            if (textBoxImięDodajPracownika.Text != String.Empty && textBoxNazwiskoDodajPracownika.Text != String.Empty && textBoxLoginDodajPracownika.Text != String.Empty && textBoxHasłoDodajPracownika.Text != String.Empty && textBoxPotwierdzHaslo.Text != String.Empty && textBoxKodDodajPracownika.Text != String.Empty && numericUpDownPensjaDodajPracownika.Value >0 && numericUpDownStawkaDodajPracownika.Value > 0 && comboBoxUprawnieniaDodajPracownika.SelectedItem != null)
            {
                if (textBoxHasłoDodajPracownika.Text.Length > 6 && textBoxHasłoDodajPracownika.Text == textBoxPotwierdzHaslo.Text)
                {
                    user.FirstName = textBoxImięDodajPracownika.Text;
                    user.LastName = textBoxNazwiskoDodajPracownika.Text;
                    user.PasswordHash = textBoxHasłoDodajPracownika.Text;
                    user.Login = textBoxLoginDodajPracownika.Text;
                    user.CodeHash = textBoxKodDodajPracownika.Text;
                    user.BaseSalary = numericUpDownPensjaDodajPracownika.Value;
                    user.HourlyRate = numericUpDownStawkaDodajPracownika.Value;
                    user.Permission = comboBoxUprawnieniaDodajPracownika.SelectedItem.ToString();
                    DialogResult = DialogResult.OK;
                }
                else
                { 
                    MessageBox.Show("Hasła nie są takie same lub podane hasło jest za krótkie");
                }
               
            } else
                {
                    MessageBox.Show("Uzupełnij informacje");
                }
          
        }

        //Anuluj wybór pracownika
        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //Usunięcie pracownika wybranego z formularza EdycjaPracownika
        private void buttonUsuń_Click(object sender, EventArgs e)
        {
            if (textBoxImięDodajPracownika.Text != string.Empty && textBoxNazwiskoDodajPracownika.Text != string.Empty && textBoxHasłoDodajPracownika.Text != string.Empty
               && textBoxLoginDodajPracownika.Text != string.Empty && textBoxKodDodajPracownika.Text != string.Empty && numericUpDownPensjaDodajPracownika.Value > 0 &&
                numericUpDownStawkaDodajPracownika.Value > 0 && comboBoxUprawnieniaDodajPracownika.SelectedItem != null)
            {
                if (textBoxHasłoDodajPracownika.Text == textBoxPotwierdzHaslo.Text && textBoxHasłoDodajPracownika.Text.Length > 0)
                {
                    var a = textBoxImięDodajPracownika.Text;
                    var b = textBoxNazwiskoDodajPracownika.Text;
                    var c = textBoxHasłoDodajPracownika.Text;
                    var d = textBoxLoginDodajPracownika.Text;
                    var f = textBoxKodDodajPracownika.Text;
                    var g = numericUpDownPensjaDodajPracownika.Value;
                    var h = numericUpDownStawkaDodajPracownika.Value;
                    var i = Convert.ToString(comboBoxUprawnieniaDodajPracownika.SelectedItem);
                    var id = Convert.ToInt32(textBox1.Text);
                    user.DELETEUSER(a, b, c, d, f, g, h, i, id);
                    DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij informacje");
            }
            buttonZapiszDodajPracownika.Enabled = false;

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
            if (e.KeyChar == (char)Keys.Space)
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
            if (e.KeyChar == (char)Keys.Space)
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

        //Szyfrowanie hasła i potwierdzenia hasła
        private void checkBoxPokazHaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPokazHaslo.Checked == true)
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
        private void ZmieńDanePracownika_FormClosing(object sender, FormClosingEventArgs e)
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
