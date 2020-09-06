namespace ModułZarządzaniaPersonelem
{
    partial class ModyfikacjaHarmonogramuPracownik
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
            this.components = new System.ComponentModel.Container();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonZaktualizuj = new System.Windows.Forms.Button();
            this.labelZaktualizujStatus = new System.Windows.Forms.Label();
            this.comboBoxZaktualizujStatus = new System.Windows.Forms.ComboBox();
            this.scheduleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modułZarządzaniaPersonelemDataSet = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSet();
            this.labelAktualnyStatus = new System.Windows.Forms.Label();
            this.textBoxAktualnyStatus = new System.Windows.Forms.TextBox();
            this.labelScheduleID = new System.Windows.Forms.Label();
            this.textBoxScheduleID = new System.Windows.Forms.TextBox();
            this.textBoxWpiszHaslo = new System.Windows.Forms.TextBox();
            this.labelWpiszHaslo = new System.Windows.Forms.Label();
            this.checkBoxPokazHaslo = new System.Windows.Forms.CheckBox();
            this.scheduleStatusTableAdapter = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSetTableAdapters.ScheduleStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(23, 471);
            this.buttonAnuluj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(161, 28);
            this.buttonAnuluj.TabIndex = 15;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonZaktualizuj
            // 
            this.buttonZaktualizuj.Location = new System.Drawing.Point(23, 421);
            this.buttonZaktualizuj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZaktualizuj.Name = "buttonZaktualizuj";
            this.buttonZaktualizuj.Size = new System.Drawing.Size(161, 28);
            this.buttonZaktualizuj.TabIndex = 14;
            this.buttonZaktualizuj.Text = "Zaktualizuj";
            this.buttonZaktualizuj.UseVisualStyleBackColor = true;
            this.buttonZaktualizuj.Click += new System.EventHandler(this.buttonZaktualizuj_Click);
            // 
            // labelZaktualizujStatus
            // 
            this.labelZaktualizujStatus.AutoSize = true;
            this.labelZaktualizujStatus.Location = new System.Drawing.Point(19, 199);
            this.labelZaktualizujStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZaktualizujStatus.Name = "labelZaktualizujStatus";
            this.labelZaktualizujStatus.Size = new System.Drawing.Size(172, 17);
            this.labelZaktualizujStatus.TabIndex = 13;
            this.labelZaktualizujStatus.Text = "Zaktualizuj status zadania";
            // 
            // comboBoxZaktualizujStatus
            // 
            this.comboBoxZaktualizujStatus.FormattingEnabled = true;
            this.comboBoxZaktualizujStatus.Location = new System.Drawing.Point(23, 241);
            this.comboBoxZaktualizujStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxZaktualizujStatus.Name = "comboBoxZaktualizujStatus";
            this.comboBoxZaktualizujStatus.Size = new System.Drawing.Size(160, 24);
            this.comboBoxZaktualizujStatus.TabIndex = 12;
            // 
            // scheduleStatusBindingSource
            // 
            this.scheduleStatusBindingSource.DataMember = "ScheduleStatus";
            this.scheduleStatusBindingSource.DataSource = this.modułZarządzaniaPersonelemDataSet;
            // 
            // modułZarządzaniaPersonelemDataSet
            // 
            this.modułZarządzaniaPersonelemDataSet.DataSetName = "ModułZarządzaniaPersonelemDataSet";
            this.modułZarządzaniaPersonelemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAktualnyStatus
            // 
            this.labelAktualnyStatus.AutoSize = true;
            this.labelAktualnyStatus.Location = new System.Drawing.Point(25, 100);
            this.labelAktualnyStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAktualnyStatus.Name = "labelAktualnyStatus";
            this.labelAktualnyStatus.Size = new System.Drawing.Size(158, 17);
            this.labelAktualnyStatus.TabIndex = 11;
            this.labelAktualnyStatus.Text = "Aktualny status zadania";
            // 
            // textBoxAktualnyStatus
            // 
            this.textBoxAktualnyStatus.Enabled = false;
            this.textBoxAktualnyStatus.Location = new System.Drawing.Point(23, 140);
            this.textBoxAktualnyStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAktualnyStatus.Name = "textBoxAktualnyStatus";
            this.textBoxAktualnyStatus.Size = new System.Drawing.Size(160, 22);
            this.textBoxAktualnyStatus.TabIndex = 10;
            // 
            // labelScheduleID
            // 
            this.labelScheduleID.AutoSize = true;
            this.labelScheduleID.Location = new System.Drawing.Point(61, 11);
            this.labelScheduleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScheduleID.Name = "labelScheduleID";
            this.labelScheduleID.Size = new System.Drawing.Size(84, 17);
            this.labelScheduleID.TabIndex = 9;
            this.labelScheduleID.Text = "Schedule ID";
            // 
            // textBoxScheduleID
            // 
            this.textBoxScheduleID.Enabled = false;
            this.textBoxScheduleID.Location = new System.Drawing.Point(63, 47);
            this.textBoxScheduleID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScheduleID.Name = "textBoxScheduleID";
            this.textBoxScheduleID.Size = new System.Drawing.Size(77, 22);
            this.textBoxScheduleID.TabIndex = 8;
            // 
            // textBoxWpiszHaslo
            // 
            this.textBoxWpiszHaslo.Location = new System.Drawing.Point(23, 334);
            this.textBoxWpiszHaslo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWpiszHaslo.Name = "textBoxWpiszHaslo";
            this.textBoxWpiszHaslo.PasswordChar = '*';
            this.textBoxWpiszHaslo.Size = new System.Drawing.Size(160, 22);
            this.textBoxWpiszHaslo.TabIndex = 16;
            // 
            // labelWpiszHaslo
            // 
            this.labelWpiszHaslo.AutoSize = true;
            this.labelWpiszHaslo.Location = new System.Drawing.Point(17, 293);
            this.labelWpiszHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWpiszHaslo.Name = "labelWpiszHaslo";
            this.labelWpiszHaslo.Size = new System.Drawing.Size(164, 17);
            this.labelWpiszHaslo.TabIndex = 17;
            this.labelWpiszHaslo.Text = "Wpisz hasło użytkownika";
            // 
            // checkBoxPokazHaslo
            // 
            this.checkBoxPokazHaslo.AutoSize = true;
            this.checkBoxPokazHaslo.Location = new System.Drawing.Point(45, 370);
            this.checkBoxPokazHaslo.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPokazHaslo.Name = "checkBoxPokazHaslo";
            this.checkBoxPokazHaslo.Size = new System.Drawing.Size(107, 21);
            this.checkBoxPokazHaslo.TabIndex = 18;
            this.checkBoxPokazHaslo.Text = "Pokaż hasło";
            this.checkBoxPokazHaslo.UseVisualStyleBackColor = true;
            this.checkBoxPokazHaslo.CheckedChanged += new System.EventHandler(this.checkBoxPokazHaslo_CheckedChanged);
            // 
            // scheduleStatusTableAdapter
            // 
            this.scheduleStatusTableAdapter.ClearBeforeFill = true;
            // 
            // ModyfikacjaHarmonogramuPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 519);
            this.Controls.Add(this.checkBoxPokazHaslo);
            this.Controls.Add(this.labelWpiszHaslo);
            this.Controls.Add(this.textBoxWpiszHaslo);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonZaktualizuj);
            this.Controls.Add(this.labelZaktualizujStatus);
            this.Controls.Add(this.comboBoxZaktualizujStatus);
            this.Controls.Add(this.labelAktualnyStatus);
            this.Controls.Add(this.textBoxAktualnyStatus);
            this.Controls.Add(this.labelScheduleID);
            this.Controls.Add(this.textBoxScheduleID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModyfikacjaHarmonogramuPracownik";
            this.Text = "ModyfikacjaHarmonogramuPracownik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModyfikacjaHarmonogramuPracownik_FormClosing);
            this.Load += new System.EventHandler(this.ModyfikacjaHarmonogramuPracownik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonZaktualizuj;
        private System.Windows.Forms.Label labelZaktualizujStatus;
        private System.Windows.Forms.ComboBox comboBoxZaktualizujStatus;
        private System.Windows.Forms.Label labelAktualnyStatus;
        private System.Windows.Forms.TextBox textBoxAktualnyStatus;
        private System.Windows.Forms.Label labelScheduleID;
        private System.Windows.Forms.TextBox textBoxScheduleID;
        private System.Windows.Forms.TextBox textBoxWpiszHaslo;
        private System.Windows.Forms.Label labelWpiszHaslo;
        private System.Windows.Forms.CheckBox checkBoxPokazHaslo;
        private ModułZarządzaniaPersonelemDataSet modułZarządzaniaPersonelemDataSet;
        private System.Windows.Forms.BindingSource scheduleStatusBindingSource;
        private ModułZarządzaniaPersonelemDataSetTableAdapters.ScheduleStatusTableAdapter scheduleStatusTableAdapter;
    }
}