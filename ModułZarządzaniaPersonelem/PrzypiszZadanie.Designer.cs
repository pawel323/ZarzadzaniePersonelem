namespace ModułZarządzaniaPersonelem
{
    partial class PrzypiszZadanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzypiszZadanie));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modułZarządzaniaPersonelemDataSet = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBoxImię = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOpisZadania = new System.Windows.Forms.ComboBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxStatusZadania = new System.Windows.Forms.ComboBox();
            this.scheduleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownGodzina = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinuty = new System.Windows.Forms.NumericUpDown();
            this.textBoxGodzina = new System.Windows.Forms.TextBox();
            this.textBoxMinuty = new System.Windows.Forms.TextBox();
            this.buttonPrzypiszZadanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonWróc = new System.Windows.Forms.Button();
            this.userTableAdapter = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSetTableAdapters.UserTableAdapter();
            this.taskTableAdapter = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSetTableAdapters.TaskTableAdapter();
            this.scheduleStatusTableAdapter = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSetTableAdapters.ScheduleStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodzina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuty)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.userBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(676, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.modułZarządzaniaPersonelemDataSet;
            // 
            // modułZarządzaniaPersonelemDataSet
            // 
            this.modułZarządzaniaPersonelemDataSet.DataSetName = "ModułZarządzaniaPersonelemDataSet";
            this.modułZarządzaniaPersonelemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Enabled = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // textBoxImię
            // 
            this.textBoxImię.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "firstName", true));
            this.textBoxImię.Enabled = false;
            this.textBoxImię.Location = new System.Drawing.Point(108, 66);
            this.textBoxImię.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImię.Name = "textBoxImię";
            this.textBoxImię.Size = new System.Drawing.Size(132, 22);
            this.textBoxImię.TabIndex = 1;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "lastName", true));
            this.textBoxNazwisko.Enabled = false;
            this.textBoxNazwisko.Location = new System.Drawing.Point(384, 66);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(132, 22);
            this.textBoxNazwisko.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 138);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBoxOpisZadania
            // 
            this.comboBoxOpisZadania.FormattingEnabled = true;
            this.comboBoxOpisZadania.Location = new System.Drawing.Point(248, 209);
            this.comboBoxOpisZadania.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOpisZadania.Name = "comboBoxOpisZadania";
            this.comboBoxOpisZadania.Size = new System.Drawing.Size(160, 24);
            this.comboBoxOpisZadania.TabIndex = 4;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.modułZarządzaniaPersonelemDataSet;
            // 
            // comboBoxStatusZadania
            // 
            this.comboBoxStatusZadania.FormattingEnabled = true;
            this.comboBoxStatusZadania.Location = new System.Drawing.Point(248, 283);
            this.comboBoxStatusZadania.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatusZadania.Name = "comboBoxStatusZadania";
            this.comboBoxStatusZadania.Size = new System.Drawing.Size(160, 24);
            this.comboBoxStatusZadania.TabIndex = 5;
            // 
            // scheduleStatusBindingSource
            // 
            this.scheduleStatusBindingSource.DataMember = "ScheduleStatus";
            this.scheduleStatusBindingSource.DataSource = this.modułZarządzaniaPersonelemDataSet;
            // 
            // numericUpDownGodzina
            // 
            this.numericUpDownGodzina.Location = new System.Drawing.Point(61, 352);
            this.numericUpDownGodzina.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownGodzina.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownGodzina.Name = "numericUpDownGodzina";
            this.numericUpDownGodzina.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownGodzina.TabIndex = 6;
            this.numericUpDownGodzina.ValueChanged += new System.EventHandler(this.numericUpDownGodzina_ValueChanged);
            // 
            // numericUpDownMinuty
            // 
            this.numericUpDownMinuty.Location = new System.Drawing.Point(447, 352);
            this.numericUpDownMinuty.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMinuty.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinuty.Name = "numericUpDownMinuty";
            this.numericUpDownMinuty.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownMinuty.TabIndex = 7;
            this.numericUpDownMinuty.ValueChanged += new System.EventHandler(this.numericUpDownMinuty_ValueChanged);
            // 
            // textBoxGodzina
            // 
            this.textBoxGodzina.Enabled = false;
            this.textBoxGodzina.Location = new System.Drawing.Point(177, 420);
            this.textBoxGodzina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGodzina.Name = "textBoxGodzina";
            this.textBoxGodzina.Size = new System.Drawing.Size(132, 22);
            this.textBoxGodzina.TabIndex = 8;
            // 
            // textBoxMinuty
            // 
            this.textBoxMinuty.Enabled = false;
            this.textBoxMinuty.Location = new System.Drawing.Point(359, 420);
            this.textBoxMinuty.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinuty.Name = "textBoxMinuty";
            this.textBoxMinuty.Size = new System.Drawing.Size(132, 22);
            this.textBoxMinuty.TabIndex = 9;
            // 
            // buttonPrzypiszZadanie
            // 
            this.buttonPrzypiszZadanie.Location = new System.Drawing.Point(239, 487);
            this.buttonPrzypiszZadanie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrzypiszZadanie.Name = "buttonPrzypiszZadanie";
            this.buttonPrzypiszZadanie.Size = new System.Drawing.Size(193, 62);
            this.buttonPrzypiszZadanie.TabIndex = 10;
            this.buttonPrzypiszZadanie.Text = "Przypisz zadanie";
            this.buttonPrzypiszZadanie.UseVisualStyleBackColor = true;
            this.buttonPrzypiszZadanie.Click += new System.EventHandler(this.buttonPrzypiszZadanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data przydzielenia zadania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Opis zadania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Status zadania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Godzina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Minuty";
            // 
            // buttonWróc
            // 
            this.buttonWróc.Location = new System.Drawing.Point(239, 566);
            this.buttonWróc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWróc.Name = "buttonWróc";
            this.buttonWróc.Size = new System.Drawing.Size(193, 28);
            this.buttonWróc.TabIndex = 18;
            this.buttonWróc.Text = "Wróć";
            this.buttonWróc.UseVisualStyleBackColor = true;
            this.buttonWróc.Click += new System.EventHandler(this.buttonWróc_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleStatusTableAdapter
            // 
            this.scheduleStatusTableAdapter.ClearBeforeFill = true;
            // 
            // PrzypiszZadanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 609);
            this.Controls.Add(this.buttonWróc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrzypiszZadanie);
            this.Controls.Add(this.textBoxMinuty);
            this.Controls.Add(this.textBoxGodzina);
            this.Controls.Add(this.numericUpDownMinuty);
            this.Controls.Add(this.numericUpDownGodzina);
            this.Controls.Add(this.comboBoxStatusZadania);
            this.Controls.Add(this.comboBoxOpisZadania);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImię);
            this.Controls.Add(this.bindingNavigator1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrzypiszZadanie";
            this.Text = "PrzypiszZadanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrzypiszZadanie_FormClosing);
            this.Load += new System.EventHandler(this.PrzypiszZadanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodzina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textBoxImię;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxOpisZadania;
        private System.Windows.Forms.ComboBox comboBoxStatusZadania;
        private System.Windows.Forms.NumericUpDown numericUpDownGodzina;
        private System.Windows.Forms.NumericUpDown numericUpDownMinuty;
        private System.Windows.Forms.TextBox textBoxGodzina;
        private System.Windows.Forms.TextBox textBoxMinuty;
        private System.Windows.Forms.Button buttonPrzypiszZadanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonWróc;
        private ModułZarządzaniaPersonelemDataSet modułZarządzaniaPersonelemDataSet;
        private ModułZarządzaniaPersonelemDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private ModułZarządzaniaPersonelemDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.BindingSource scheduleStatusBindingSource;
        private ModułZarządzaniaPersonelemDataSetTableAdapters.ScheduleStatusTableAdapter scheduleStatusTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}