namespace ModułZarządzaniaPersonelem
{
    partial class ModyfikacjaHarmonogramu
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
            this.textBoxScheduleID = new System.Windows.Forms.TextBox();
            this.labelScheduleID = new System.Windows.Forms.Label();
            this.textBoxAktualnyStatus = new System.Windows.Forms.TextBox();
            this.labelAktualnyStatus = new System.Windows.Forms.Label();
            this.comboBoxZaktualizujStatus = new System.Windows.Forms.ComboBox();
            this.scheduleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modułZarządzaniaPersonelemDataSet = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSet();
            this.labelZaktualizujStatus = new System.Windows.Forms.Label();
            this.buttonZaktualizuj = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.scheduleStatusTableAdapter = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSetTableAdapters.ScheduleStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxScheduleID
            // 
            this.textBoxScheduleID.Enabled = false;
            this.textBoxScheduleID.Location = new System.Drawing.Point(69, 70);
            this.textBoxScheduleID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScheduleID.Name = "textBoxScheduleID";
            this.textBoxScheduleID.Size = new System.Drawing.Size(77, 22);
            this.textBoxScheduleID.TabIndex = 0;
            // 
            // labelScheduleID
            // 
            this.labelScheduleID.AutoSize = true;
            this.labelScheduleID.Location = new System.Drawing.Point(68, 34);
            this.labelScheduleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScheduleID.Name = "labelScheduleID";
            this.labelScheduleID.Size = new System.Drawing.Size(84, 17);
            this.labelScheduleID.TabIndex = 1;
            this.labelScheduleID.Text = "Schedule ID";
            // 
            // textBoxAktualnyStatus
            // 
            this.textBoxAktualnyStatus.Enabled = false;
            this.textBoxAktualnyStatus.Location = new System.Drawing.Point(29, 164);
            this.textBoxAktualnyStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAktualnyStatus.Name = "textBoxAktualnyStatus";
            this.textBoxAktualnyStatus.Size = new System.Drawing.Size(160, 22);
            this.textBoxAktualnyStatus.TabIndex = 2;
            // 
            // labelAktualnyStatus
            // 
            this.labelAktualnyStatus.AutoSize = true;
            this.labelAktualnyStatus.Location = new System.Drawing.Point(32, 123);
            this.labelAktualnyStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAktualnyStatus.Name = "labelAktualnyStatus";
            this.labelAktualnyStatus.Size = new System.Drawing.Size(158, 17);
            this.labelAktualnyStatus.TabIndex = 3;
            this.labelAktualnyStatus.Text = "Aktualny status zadania";
            // 
            // comboBoxZaktualizujStatus
            // 
            this.comboBoxZaktualizujStatus.FormattingEnabled = true;
            this.comboBoxZaktualizujStatus.Location = new System.Drawing.Point(29, 265);
            this.comboBoxZaktualizujStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxZaktualizujStatus.Name = "comboBoxZaktualizujStatus";
            this.comboBoxZaktualizujStatus.Size = new System.Drawing.Size(160, 24);
            this.comboBoxZaktualizujStatus.TabIndex = 4;
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
            // labelZaktualizujStatus
            // 
            this.labelZaktualizujStatus.AutoSize = true;
            this.labelZaktualizujStatus.Location = new System.Drawing.Point(25, 223);
            this.labelZaktualizujStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZaktualizujStatus.Name = "labelZaktualizujStatus";
            this.labelZaktualizujStatus.Size = new System.Drawing.Size(172, 17);
            this.labelZaktualizujStatus.TabIndex = 5;
            this.labelZaktualizujStatus.Text = "Zaktualizuj status zadania";
            // 
            // buttonZaktualizuj
            // 
            this.buttonZaktualizuj.Location = new System.Drawing.Point(29, 338);
            this.buttonZaktualizuj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZaktualizuj.Name = "buttonZaktualizuj";
            this.buttonZaktualizuj.Size = new System.Drawing.Size(161, 28);
            this.buttonZaktualizuj.TabIndex = 6;
            this.buttonZaktualizuj.Text = "Zaktualizuj";
            this.buttonZaktualizuj.UseVisualStyleBackColor = true;
            this.buttonZaktualizuj.Click += new System.EventHandler(this.buttonZaktualizuj_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(29, 389);
            this.buttonAnuluj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(161, 28);
            this.buttonAnuluj.TabIndex = 7;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // scheduleStatusTableAdapter
            // 
            this.scheduleStatusTableAdapter.ClearBeforeFill = true;
            // 
            // ModyfikacjaHarmonogramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 436);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonZaktualizuj);
            this.Controls.Add(this.labelZaktualizujStatus);
            this.Controls.Add(this.comboBoxZaktualizujStatus);
            this.Controls.Add(this.labelAktualnyStatus);
            this.Controls.Add(this.textBoxAktualnyStatus);
            this.Controls.Add(this.labelScheduleID);
            this.Controls.Add(this.textBoxScheduleID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModyfikacjaHarmonogramu";
            this.Text = "ModyfikacjaHarmonogramu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModyfikacjaHarmonogramu_FormClosing);
            this.Load += new System.EventHandler(this.ModyfikacjaHarmonogramu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxScheduleID;
        private System.Windows.Forms.Label labelScheduleID;
        private System.Windows.Forms.TextBox textBoxAktualnyStatus;
        private System.Windows.Forms.Label labelAktualnyStatus;
        private System.Windows.Forms.ComboBox comboBoxZaktualizujStatus;
        private System.Windows.Forms.Label labelZaktualizujStatus;
        private System.Windows.Forms.Button buttonZaktualizuj;
        private System.Windows.Forms.Button buttonAnuluj;
        private ModułZarządzaniaPersonelemDataSet modułZarządzaniaPersonelemDataSet;
        private System.Windows.Forms.BindingSource scheduleStatusBindingSource;
        private ModułZarządzaniaPersonelemDataSetTableAdapters.ScheduleStatusTableAdapter scheduleStatusTableAdapter;
    }
}