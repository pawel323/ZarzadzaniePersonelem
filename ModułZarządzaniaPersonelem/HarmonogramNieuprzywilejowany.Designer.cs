﻿namespace ModułZarządzaniaPersonelem
{
    partial class HarmonogramNieuprzywilejowany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarmonogramNieuprzywilejowany));
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImię = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModyfikuj = new System.Windows.Forms.Button();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonFiltrowanie = new System.Windows.Forms.Button();
            this.modułZarządzaniaPersonelemDataSet = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Location = new System.Drawing.Point(216, 561);
            this.buttonWyloguj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(100, 28);
            this.buttonWyloguj.TabIndex = 55;
            this.buttonWyloguj.Text = "Wyloguj";
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            this.buttonWyloguj.Click += new System.EventHandler(this.buttonWyloguj_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(224, 112);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(92, 17);
            this.labelData.TabIndex = 65;
            this.labelData.Text = "Data zadania";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(363, 48);
            this.labelNazwisko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(67, 17);
            this.labelNazwisko.TabIndex = 64;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // labelImię
            // 
            this.labelImię.AutoSize = true;
            this.labelImię.Location = new System.Drawing.Point(144, 48);
            this.labelImię.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImię.Name = "labelImię";
            this.labelImię.Size = new System.Drawing.Size(33, 17);
            this.labelImię.TabIndex = 63;
            this.labelImię.Text = "Imię";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(16, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 235);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numer zadania";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numer statusu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Godzina wykonania";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // buttonModyfikuj
            // 
            this.buttonModyfikuj.Location = new System.Drawing.Point(345, 202);
            this.buttonModyfikuj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModyfikuj.Name = "buttonModyfikuj";
            this.buttonModyfikuj.Size = new System.Drawing.Size(159, 69);
            this.buttonModyfikuj.TabIndex = 61;
            this.buttonModyfikuj.Text = "Zmień status zaznaczonego zadania";
            this.buttonModyfikuj.UseVisualStyleBackColor = true;
            this.buttonModyfikuj.Click += new System.EventHandler(this.buttonModyfikuj_Click);
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Location = new System.Drawing.Point(211, 202);
            this.buttonWyszukaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(100, 69);
            this.buttonWyszukaj.TabIndex = 60;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 145);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "lastName", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(327, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "firstName", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(88, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 57;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(560, 27);
            this.bindingNavigator1.TabIndex = 56;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // buttonFiltrowanie
            // 
            this.buttonFiltrowanie.Location = new System.Drawing.Point(32, 202);
            this.buttonFiltrowanie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrowanie.Name = "buttonFiltrowanie";
            this.buttonFiltrowanie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFiltrowanie.Size = new System.Drawing.Size(147, 69);
            this.buttonFiltrowanie.TabIndex = 66;
            this.buttonFiltrowanie.Text = "Zmień dane dla filtrowania zadań";
            this.buttonFiltrowanie.UseVisualStyleBackColor = true;
            this.buttonFiltrowanie.Click += new System.EventHandler(this.buttonFiltrowanie_Click);
            // 
            // modułZarządzaniaPersonelemDataSet
            // 
            this.modułZarządzaniaPersonelemDataSet.DataSetName = "ModułZarządzaniaPersonelemDataSet";
            this.modułZarządzaniaPersonelemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.modułZarządzaniaPersonelemDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // HarmonogramNieuprzywilejowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 618);
            this.Controls.Add(this.buttonFiltrowanie);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImię);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonModyfikuj);
            this.Controls.Add(this.buttonWyszukaj);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.buttonWyloguj);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HarmonogramNieuprzywilejowany";
            this.Text = "Harmonogram dla użytkownika nieuprzywilejowanego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HarmonogramNieuprzywilejowany_FormClosing);
            this.Load += new System.EventHandler(this.HarmonogramNieuprzywilejowany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImię;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonModyfikuj;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button buttonFiltrowanie;
        private ModułZarządzaniaPersonelemDataSet modułZarządzaniaPersonelemDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private ModułZarządzaniaPersonelemDataSetTableAdapters.UserTableAdapter userTableAdapter;
    }
}