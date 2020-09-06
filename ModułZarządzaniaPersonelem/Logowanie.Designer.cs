namespace ModułZarządzaniaPersonelem
{
    partial class Logowanie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.radioButtonNieuprzywilejowany = new System.Windows.Forms.RadioButton();
            this.radioButtonUprzywilejowany = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Location = new System.Drawing.Point(75, 155);
            this.buttonZaloguj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(113, 28);
            this.buttonZaloguj.TabIndex = 5;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // radioButtonNieuprzywilejowany
            // 
            this.radioButtonNieuprzywilejowany.AutoSize = true;
            this.radioButtonNieuprzywilejowany.Location = new System.Drawing.Point(33, 90);
            this.radioButtonNieuprzywilejowany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNieuprzywilejowany.Name = "radioButtonNieuprzywilejowany";
            this.radioButtonNieuprzywilejowany.Size = new System.Drawing.Size(223, 21);
            this.radioButtonNieuprzywilejowany.TabIndex = 4;
            this.radioButtonNieuprzywilejowany.TabStop = true;
            this.radioButtonNieuprzywilejowany.Text = "Użytkownik nieuprzywilejowany";
            this.radioButtonNieuprzywilejowany.UseVisualStyleBackColor = true;
            // 
            // radioButtonUprzywilejowany
            // 
            this.radioButtonUprzywilejowany.AutoSize = true;
            this.radioButtonUprzywilejowany.Location = new System.Drawing.Point(33, 34);
            this.radioButtonUprzywilejowany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonUprzywilejowany.Name = "radioButtonUprzywilejowany";
            this.radioButtonUprzywilejowany.Size = new System.Drawing.Size(204, 21);
            this.radioButtonUprzywilejowany.TabIndex = 3;
            this.radioButtonUprzywilejowany.TabStop = true;
            this.radioButtonUprzywilejowany.Text = "Użytkownik uprzywilejowany";
            this.radioButtonUprzywilejowany.UseVisualStyleBackColor = true;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 236);
            this.Controls.Add(this.radioButtonUprzywilejowany);
            this.Controls.Add(this.radioButtonNieuprzywilejowany);
            this.Controls.Add(this.buttonZaloguj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logowanie_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.RadioButton radioButtonNieuprzywilejowany;
        private System.Windows.Forms.RadioButton radioButtonUprzywilejowany;
    }
}