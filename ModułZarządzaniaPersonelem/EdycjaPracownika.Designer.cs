namespace ModułZarządzaniaPersonelem
{
    partial class EdycjaPracownika
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonWróć = new System.Windows.Forms.Button();
            this.buttonOdśwież = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 412);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imię";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // buttonWróć
            // 
            this.buttonWróć.Location = new System.Drawing.Point(115, 489);
            this.buttonWróć.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWróć.Name = "buttonWróć";
            this.buttonWróć.Size = new System.Drawing.Size(180, 28);
            this.buttonWróć.TabIndex = 2;
            this.buttonWróć.Text = "Wróć";
            this.buttonWróć.UseVisualStyleBackColor = true;
            this.buttonWróć.Click += new System.EventHandler(this.buttonWróć_Click);
            // 
            // buttonOdśwież
            // 
            this.buttonOdśwież.Location = new System.Drawing.Point(115, 444);
            this.buttonOdśwież.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOdśwież.Name = "buttonOdśwież";
            this.buttonOdśwież.Size = new System.Drawing.Size(180, 28);
            this.buttonOdśwież.TabIndex = 3;
            this.buttonOdśwież.Text = "Odśwież";
            this.buttonOdśwież.UseVisualStyleBackColor = true;
            this.buttonOdśwież.Click += new System.EventHandler(this.buttonOdśwież_Click);
            // 
            // EdycjaPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 529);
            this.Controls.Add(this.buttonOdśwież);
            this.Controls.Add(this.buttonWróć);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EdycjaPracownika";
            this.Text = "EdycjaPracownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EdycjaPracownika_FormClosing);
            this.Load += new System.EventHandler(this.EdycjaPracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        
        private System.Windows.Forms.Button buttonWróć;
        private System.Windows.Forms.Button buttonOdśwież;
    }
}