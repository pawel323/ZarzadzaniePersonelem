using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ModułZarządzaniaPersonelem
{
    public partial class Logowanie : Form
    {
        Thread th;
        public Logowanie()
        {
            InitializeComponent();   
        }

        //Opuszczenie ekranu logowania i przejście do odpowiedniego formularza w zależności od uprawnień
        private void buttonZaloguj_Click(object sender, EventArgs e)
        {

            this.Dispose();
            th = new Thread(openForm);
            th.Start();
         
        }


        private void openForm()
        {
            if (radioButtonUprzywilejowany.Checked)
            {
                Application.Run(new PanelMenadżera());
            }
            else if (radioButtonNieuprzywilejowany.Checked)
            {
                Application.Run(new HarmonogramNieuprzywilejowany());
            }
        }

        //Komunikat potwierdzający opuszczenie programu
        private void Logowanie_FormClosing(object sender, FormClosingEventArgs e)
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
