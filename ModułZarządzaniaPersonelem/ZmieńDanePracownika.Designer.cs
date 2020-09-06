namespace ModułZarządzaniaPersonelem
{
    partial class ZmieńDanePracownika
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
            this.buttonZapiszDodajPracownika = new System.Windows.Forms.Button();
            this.comboBoxUprawnieniaDodajPracownika = new System.Windows.Forms.ComboBox();
            this.numericUpDownStawkaDodajPracownika = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPensjaDodajPracownika = new System.Windows.Forms.NumericUpDown();
            this.textBoxKodDodajPracownika = new System.Windows.Forms.TextBox();
            this.textBoxHasłoDodajPracownika = new System.Windows.Forms.TextBox();
            this.textBoxLoginDodajPracownika = new System.Windows.Forms.TextBox();
            this.textBoxNazwiskoDodajPracownika = new System.Windows.Forms.TextBox();
            this.textBoxImięDodajPracownika = new System.Windows.Forms.TextBox();
            this.labelUprawnieniaDodajPracownika = new System.Windows.Forms.Label();
            this.labelStawkaDodajPracownika = new System.Windows.Forms.Label();
            this.labelPensjaDodajPracownika = new System.Windows.Forms.Label();
            this.labelKodDodajPracownika = new System.Windows.Forms.Label();
            this.labelHasłoDodajPracownika = new System.Windows.Forms.Label();
            this.labelLoginDodajPracownika = new System.Windows.Forms.Label();
            this.labelNazwiskoDodajPracownika = new System.Windows.Forms.Label();
            this.labelImięDodajPracownika = new System.Windows.Forms.Label();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonUsuń = new System.Windows.Forms.Button();
            this.labelPotwierdzHaslo = new System.Windows.Forms.Label();
            this.textBoxPotwierdzHaslo = new System.Windows.Forms.TextBox();
            this.checkBoxPokazHaslo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStawkaDodajPracownika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPensjaDodajPracownika)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZapiszDodajPracownika
            // 
            this.buttonZapiszDodajPracownika.Location = new System.Drawing.Point(85, 630);
            this.buttonZapiszDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZapiszDodajPracownika.Name = "buttonZapiszDodajPracownika";
            this.buttonZapiszDodajPracownika.Size = new System.Drawing.Size(161, 28);
            this.buttonZapiszDodajPracownika.TabIndex = 33;
            this.buttonZapiszDodajPracownika.Text = "Zapisz";
            this.buttonZapiszDodajPracownika.UseVisualStyleBackColor = true;
            this.buttonZapiszDodajPracownika.Click += new System.EventHandler(this.buttonZapiszDodajPracownika_Click);
            // 
            // comboBoxUprawnieniaDodajPracownika
            // 
            this.comboBoxUprawnieniaDodajPracownika.FormattingEnabled = true;
            this.comboBoxUprawnieniaDodajPracownika.Items.AddRange(new object[] {
            "Uprzywilejowany",
            "Nieuprzywilejowany"});
            this.comboBoxUprawnieniaDodajPracownika.Location = new System.Drawing.Point(85, 572);
            this.comboBoxUprawnieniaDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUprawnieniaDodajPracownika.Name = "comboBoxUprawnieniaDodajPracownika";
            this.comboBoxUprawnieniaDodajPracownika.Size = new System.Drawing.Size(160, 24);
            this.comboBoxUprawnieniaDodajPracownika.TabIndex = 32;
            this.comboBoxUprawnieniaDodajPracownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUprawnieniaDodajPracownika_KeyPress);
            // 
            // numericUpDownStawkaDodajPracownika
            // 
            this.numericUpDownStawkaDodajPracownika.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownStawkaDodajPracownika.Location = new System.Drawing.Point(85, 487);
            this.numericUpDownStawkaDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownStawkaDodajPracownika.Name = "numericUpDownStawkaDodajPracownika";
            this.numericUpDownStawkaDodajPracownika.Size = new System.Drawing.Size(161, 22);
            this.numericUpDownStawkaDodajPracownika.TabIndex = 31;
            // 
            // numericUpDownPensjaDodajPracownika
            // 
            this.numericUpDownPensjaDodajPracownika.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPensjaDodajPracownika.Location = new System.Drawing.Point(85, 423);
            this.numericUpDownPensjaDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPensjaDodajPracownika.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownPensjaDodajPracownika.Name = "numericUpDownPensjaDodajPracownika";
            this.numericUpDownPensjaDodajPracownika.Size = new System.Drawing.Size(161, 22);
            this.numericUpDownPensjaDodajPracownika.TabIndex = 30;
            // 
            // textBoxKodDodajPracownika
            // 
            this.textBoxKodDodajPracownika.Location = new System.Drawing.Point(85, 359);
            this.textBoxKodDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKodDodajPracownika.MaxLength = 30;
            this.textBoxKodDodajPracownika.Name = "textBoxKodDodajPracownika";
            this.textBoxKodDodajPracownika.Size = new System.Drawing.Size(160, 22);
            this.textBoxKodDodajPracownika.TabIndex = 29;
            this.textBoxKodDodajPracownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKodDodajPracownika_KeyPress);
            // 
            // textBoxHasłoDodajPracownika
            // 
            this.textBoxHasłoDodajPracownika.Location = new System.Drawing.Point(85, 234);
            this.textBoxHasłoDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHasłoDodajPracownika.MaxLength = 30;
            this.textBoxHasłoDodajPracownika.Name = "textBoxHasłoDodajPracownika";
            this.textBoxHasłoDodajPracownika.PasswordChar = '*';
            this.textBoxHasłoDodajPracownika.Size = new System.Drawing.Size(160, 22);
            this.textBoxHasłoDodajPracownika.TabIndex = 28;
            this.textBoxHasłoDodajPracownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHasłoDodajPracownika_KeyPress);
            // 
            // textBoxLoginDodajPracownika
            // 
            this.textBoxLoginDodajPracownika.Location = new System.Drawing.Point(85, 170);
            this.textBoxLoginDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLoginDodajPracownika.MaxLength = 30;
            this.textBoxLoginDodajPracownika.Name = "textBoxLoginDodajPracownika";
            this.textBoxLoginDodajPracownika.Size = new System.Drawing.Size(160, 22);
            this.textBoxLoginDodajPracownika.TabIndex = 27;
            this.textBoxLoginDodajPracownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginDodajPracownika_KeyPress);
            // 
            // textBoxNazwiskoDodajPracownika
            // 
            this.textBoxNazwiskoDodajPracownika.Location = new System.Drawing.Point(85, 105);
            this.textBoxNazwiskoDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNazwiskoDodajPracownika.Name = "textBoxNazwiskoDodajPracownika";
            this.textBoxNazwiskoDodajPracownika.Size = new System.Drawing.Size(160, 22);
            this.textBoxNazwiskoDodajPracownika.TabIndex = 26;
            this.textBoxNazwiskoDodajPracownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazwiskoDodajPracownika_KeyPress);
            // 
            // textBoxImięDodajPracownika
            // 
            this.textBoxImięDodajPracownika.Location = new System.Drawing.Point(85, 36);
            this.textBoxImięDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxImięDodajPracownika.Name = "textBoxImięDodajPracownika";
            this.textBoxImięDodajPracownika.Size = new System.Drawing.Size(160, 22);
            this.textBoxImięDodajPracownika.TabIndex = 25;
            this.textBoxImięDodajPracownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImięDodajPracownika_KeyPress);
            // 
            // labelUprawnieniaDodajPracownika
            // 
            this.labelUprawnieniaDodajPracownika.AutoSize = true;
            this.labelUprawnieniaDodajPracownika.Location = new System.Drawing.Point(124, 540);
            this.labelUprawnieniaDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUprawnieniaDodajPracownika.Name = "labelUprawnieniaDodajPracownika";
            this.labelUprawnieniaDodajPracownika.Size = new System.Drawing.Size(86, 17);
            this.labelUprawnieniaDodajPracownika.TabIndex = 24;
            this.labelUprawnieniaDodajPracownika.Text = "Uprawnienia";
            // 
            // labelStawkaDodajPracownika
            // 
            this.labelStawkaDodajPracownika.AutoSize = true;
            this.labelStawkaDodajPracownika.Location = new System.Drawing.Point(101, 468);
            this.labelStawkaDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStawkaDodajPracownika.Name = "labelStawkaDodajPracownika";
            this.labelStawkaDodajPracownika.Size = new System.Drawing.Size(127, 17);
            this.labelStawkaDodajPracownika.TabIndex = 23;
            this.labelStawkaDodajPracownika.Text = "Stawka Godzinowa";
            // 
            // labelPensjaDodajPracownika
            // 
            this.labelPensjaDodajPracownika.AutoSize = true;
            this.labelPensjaDodajPracownika.Location = new System.Drawing.Point(140, 404);
            this.labelPensjaDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPensjaDodajPracownika.Name = "labelPensjaDodajPracownika";
            this.labelPensjaDodajPracownika.Size = new System.Drawing.Size(51, 17);
            this.labelPensjaDodajPracownika.TabIndex = 22;
            this.labelPensjaDodajPracownika.Text = "Pensja";
            // 
            // labelKodDodajPracownika
            // 
            this.labelKodDodajPracownika.AutoSize = true;
            this.labelKodDodajPracownika.Location = new System.Drawing.Point(149, 340);
            this.labelKodDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKodDodajPracownika.Name = "labelKodDodajPracownika";
            this.labelKodDodajPracownika.Size = new System.Drawing.Size(33, 17);
            this.labelKodDodajPracownika.TabIndex = 21;
            this.labelKodDodajPracownika.Text = "Kod";
            // 
            // labelHasłoDodajPracownika
            // 
            this.labelHasłoDodajPracownika.AutoSize = true;
            this.labelHasłoDodajPracownika.Location = new System.Drawing.Point(144, 214);
            this.labelHasłoDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHasłoDodajPracownika.Name = "labelHasłoDodajPracownika";
            this.labelHasłoDodajPracownika.Size = new System.Drawing.Size(44, 17);
            this.labelHasłoDodajPracownika.TabIndex = 20;
            this.labelHasłoDodajPracownika.Text = "Hasło";
            // 
            // labelLoginDodajPracownika
            // 
            this.labelLoginDodajPracownika.AutoSize = true;
            this.labelLoginDodajPracownika.Location = new System.Drawing.Point(144, 150);
            this.labelLoginDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginDodajPracownika.Name = "labelLoginDodajPracownika";
            this.labelLoginDodajPracownika.Size = new System.Drawing.Size(43, 17);
            this.labelLoginDodajPracownika.TabIndex = 19;
            this.labelLoginDodajPracownika.Text = "Login";
            // 
            // labelNazwiskoDodajPracownika
            // 
            this.labelNazwiskoDodajPracownika.AutoSize = true;
            this.labelNazwiskoDodajPracownika.Location = new System.Drawing.Point(135, 85);
            this.labelNazwiskoDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNazwiskoDodajPracownika.Name = "labelNazwiskoDodajPracownika";
            this.labelNazwiskoDodajPracownika.Size = new System.Drawing.Size(67, 17);
            this.labelNazwiskoDodajPracownika.TabIndex = 18;
            this.labelNazwiskoDodajPracownika.Text = "Nazwisko";
            // 
            // labelImięDodajPracownika
            // 
            this.labelImięDodajPracownika.AutoSize = true;
            this.labelImięDodajPracownika.Location = new System.Drawing.Point(153, 16);
            this.labelImięDodajPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImięDodajPracownika.Name = "labelImięDodajPracownika";
            this.labelImięDodajPracownika.Size = new System.Drawing.Size(33, 17);
            this.labelImięDodajPracownika.TabIndex = 17;
            this.labelImięDodajPracownika.Text = "Imię";
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(85, 718);
            this.buttonAnuluj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(161, 28);
            this.buttonAnuluj.TabIndex = 34;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonUsuń
            // 
            this.buttonUsuń.Location = new System.Drawing.Point(85, 676);
            this.buttonUsuń.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUsuń.Name = "buttonUsuń";
            this.buttonUsuń.Size = new System.Drawing.Size(161, 28);
            this.buttonUsuń.TabIndex = 35;
            this.buttonUsuń.Text = "Usuń";
            this.buttonUsuń.UseVisualStyleBackColor = true;
            this.buttonUsuń.Click += new System.EventHandler(this.buttonUsuń_Click);
            // 
            // labelPotwierdzHaslo
            // 
            this.labelPotwierdzHaslo.AutoSize = true;
            this.labelPotwierdzHaslo.Location = new System.Drawing.Point(112, 277);
            this.labelPotwierdzHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPotwierdzHaslo.Name = "labelPotwierdzHaslo";
            this.labelPotwierdzHaslo.Size = new System.Drawing.Size(107, 17);
            this.labelPotwierdzHaslo.TabIndex = 36;
            this.labelPotwierdzHaslo.Text = "Potwierdź hasło";
            // 
            // textBoxPotwierdzHaslo
            // 
            this.textBoxPotwierdzHaslo.Location = new System.Drawing.Point(85, 302);
            this.textBoxPotwierdzHaslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPotwierdzHaslo.MaxLength = 30;
            this.textBoxPotwierdzHaslo.Name = "textBoxPotwierdzHaslo";
            this.textBoxPotwierdzHaslo.PasswordChar = '*';
            this.textBoxPotwierdzHaslo.Size = new System.Drawing.Size(160, 22);
            this.textBoxPotwierdzHaslo.TabIndex = 37;
            // 
            // checkBoxPokazHaslo
            // 
            this.checkBoxPokazHaslo.AutoSize = true;
            this.checkBoxPokazHaslo.Location = new System.Drawing.Point(259, 271);
            this.checkBoxPokazHaslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPokazHaslo.Name = "checkBoxPokazHaslo";
            this.checkBoxPokazHaslo.Size = new System.Drawing.Size(107, 21);
            this.checkBoxPokazHaslo.TabIndex = 38;
            this.checkBoxPokazHaslo.Text = "Pokaż hasło";
            this.checkBoxPokazHaslo.UseVisualStyleBackColor = true;
            this.checkBoxPokazHaslo.CheckedChanged += new System.EventHandler(this.checkBoxPokazHaslo_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(296, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 22);
            this.textBox1.TabIndex = 39;
            // 
            // ZmieńDanePracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 770);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxPokazHaslo);
            this.Controls.Add(this.textBoxPotwierdzHaslo);
            this.Controls.Add(this.labelPotwierdzHaslo);
            this.Controls.Add(this.buttonUsuń);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonZapiszDodajPracownika);
            this.Controls.Add(this.comboBoxUprawnieniaDodajPracownika);
            this.Controls.Add(this.numericUpDownStawkaDodajPracownika);
            this.Controls.Add(this.numericUpDownPensjaDodajPracownika);
            this.Controls.Add(this.textBoxKodDodajPracownika);
            this.Controls.Add(this.textBoxHasłoDodajPracownika);
            this.Controls.Add(this.textBoxLoginDodajPracownika);
            this.Controls.Add(this.textBoxNazwiskoDodajPracownika);
            this.Controls.Add(this.textBoxImięDodajPracownika);
            this.Controls.Add(this.labelUprawnieniaDodajPracownika);
            this.Controls.Add(this.labelStawkaDodajPracownika);
            this.Controls.Add(this.labelPensjaDodajPracownika);
            this.Controls.Add(this.labelKodDodajPracownika);
            this.Controls.Add(this.labelHasłoDodajPracownika);
            this.Controls.Add(this.labelLoginDodajPracownika);
            this.Controls.Add(this.labelNazwiskoDodajPracownika);
            this.Controls.Add(this.labelImięDodajPracownika);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ZmieńDanePracownika";
            this.Text = "ZmieńDanePracownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZmieńDanePracownika_FormClosing);
            this.Load += new System.EventHandler(this.ZmieńDanePracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStawkaDodajPracownika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPensjaDodajPracownika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZapiszDodajPracownika;
        private System.Windows.Forms.ComboBox comboBoxUprawnieniaDodajPracownika;
        private System.Windows.Forms.NumericUpDown numericUpDownStawkaDodajPracownika;
        private System.Windows.Forms.NumericUpDown numericUpDownPensjaDodajPracownika;
        private System.Windows.Forms.TextBox textBoxKodDodajPracownika;
        private System.Windows.Forms.TextBox textBoxHasłoDodajPracownika;
        private System.Windows.Forms.TextBox textBoxLoginDodajPracownika;
        private System.Windows.Forms.TextBox textBoxNazwiskoDodajPracownika;
        private System.Windows.Forms.TextBox textBoxImięDodajPracownika;
        private System.Windows.Forms.Label labelUprawnieniaDodajPracownika;
        private System.Windows.Forms.Label labelStawkaDodajPracownika;
        private System.Windows.Forms.Label labelPensjaDodajPracownika;
        private System.Windows.Forms.Label labelKodDodajPracownika;
        private System.Windows.Forms.Label labelHasłoDodajPracownika;
        private System.Windows.Forms.Label labelLoginDodajPracownika;
        private System.Windows.Forms.Label labelNazwiskoDodajPracownika;
        private System.Windows.Forms.Label labelImięDodajPracownika;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonUsuń;
        private System.Windows.Forms.Label labelPotwierdzHaslo;
        private System.Windows.Forms.TextBox textBoxPotwierdzHaslo;
        private System.Windows.Forms.CheckBox checkBoxPokazHaslo;
        private System.Windows.Forms.TextBox textBox1;
    }
}