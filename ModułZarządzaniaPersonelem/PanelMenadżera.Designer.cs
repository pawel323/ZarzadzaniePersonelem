namespace ModułZarządzaniaPersonelem
{
    partial class PanelMenadżera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMenadżera));
            this.buttonEdytujPracownika = new System.Windows.Forms.Button();
            this.labelListaPracowników = new System.Windows.Forms.Label();
            this.buttonDodajPracownika = new System.Windows.Forms.Button();
            this.labelListaZadań = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonModyfikujZadanie = new System.Windows.Forms.Button();
            this.textBoxIDZadania = new System.Windows.Forms.TextBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modułZarządzaniaPersonelemDataSet = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSet();
            this.labelIDzadania = new System.Windows.Forms.Label();
            this.OpisZadania = new System.Windows.Forms.Label();
            this.NazwaZadania = new System.Windows.Forms.Label();
            this.txtbNazwaZadania = new System.Windows.Forms.TextBox();
            this.txtbOpisZadania = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonZapiszZadanie = new System.Windows.Forms.Button();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelNazwa = new System.Windows.Forms.Label();
            this.labelDodajZadanie = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.buttonPrzypisz = new System.Windows.Forms.Button();
            this.labelData1 = new System.Windows.Forms.Label();
            this.buttonWyświetl = new System.Windows.Forms.Button();
            this.taskTableAdapter = new ModułZarządzaniaPersonelem.ModułZarządzaniaPersonelemDataSetTableAdapters.TaskTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdytujPracownika
            // 
            this.buttonEdytujPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdytujPracownika.Location = new System.Drawing.Point(473, 581);
            this.buttonEdytujPracownika.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdytujPracownika.Name = "buttonEdytujPracownika";
            this.buttonEdytujPracownika.Size = new System.Drawing.Size(257, 68);
            this.buttonEdytujPracownika.TabIndex = 52;
            this.buttonEdytujPracownika.Text = "Edytuj pracownika";
            this.buttonEdytujPracownika.UseVisualStyleBackColor = true;
            this.buttonEdytujPracownika.Click += new System.EventHandler(this.buttonEdytujPracownika_Click);
            // 
            // labelListaPracowników
            // 
            this.labelListaPracowników.AutoSize = true;
            this.labelListaPracowników.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelListaPracowników.Location = new System.Drawing.Point(500, 432);
            this.labelListaPracowników.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaPracowników.Name = "labelListaPracowników";
            this.labelListaPracowników.Size = new System.Drawing.Size(190, 25);
            this.labelListaPracowników.TabIndex = 51;
            this.labelListaPracowników.Text = "Lista Pracowników";
            // 
            // buttonDodajPracownika
            // 
            this.buttonDodajPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajPracownika.Location = new System.Drawing.Point(473, 492);
            this.buttonDodajPracownika.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajPracownika.Name = "buttonDodajPracownika";
            this.buttonDodajPracownika.Size = new System.Drawing.Size(259, 63);
            this.buttonDodajPracownika.TabIndex = 50;
            this.buttonDodajPracownika.Text = "Dodaj Pracownika";
            this.buttonDodajPracownika.UseVisualStyleBackColor = true;
            this.buttonDodajPracownika.Click += new System.EventHandler(this.buttonDodajPracownika_Click);
            // 
            // labelListaZadań
            // 
            this.labelListaZadań.AutoSize = true;
            this.labelListaZadań.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelListaZadań.Location = new System.Drawing.Point(84, 331);
            this.labelListaZadań.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaZadań.Name = "labelListaZadań";
            this.labelListaZadań.Size = new System.Drawing.Size(125, 25);
            this.labelListaZadań.TabIndex = 49;
            this.labelListaZadań.Text = "Lista Zadań";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonModyfikujZadanie);
            this.panel1.Controls.Add(this.textBoxIDZadania);
            this.panel1.Controls.Add(this.labelIDzadania);
            this.panel1.Controls.Add(this.OpisZadania);
            this.panel1.Controls.Add(this.NazwaZadania);
            this.panel1.Controls.Add(this.txtbNazwaZadania);
            this.panel1.Controls.Add(this.txtbOpisZadania);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Location = new System.Drawing.Point(27, 378);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 336);
            this.panel1.TabIndex = 48;
            // 
            // buttonModyfikujZadanie
            // 
            this.buttonModyfikujZadanie.Location = new System.Drawing.Point(41, 271);
            this.buttonModyfikujZadanie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModyfikujZadanie.Name = "buttonModyfikujZadanie";
            this.buttonModyfikujZadanie.Size = new System.Drawing.Size(176, 44);
            this.buttonModyfikujZadanie.TabIndex = 7;
            this.buttonModyfikujZadanie.Text = "Modyfikuj zadanie";
            this.buttonModyfikujZadanie.UseVisualStyleBackColor = true;
            this.buttonModyfikujZadanie.Click += new System.EventHandler(this.buttonModyfikujZadanie_Click);
            // 
            // textBoxIDZadania
            // 
            this.textBoxIDZadania.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "task_ID", true));
            this.textBoxIDZadania.Enabled = false;
            this.textBoxIDZadania.Location = new System.Drawing.Point(91, 71);
            this.textBoxIDZadania.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDZadania.Name = "textBoxIDZadania";
            this.textBoxIDZadania.Size = new System.Drawing.Size(80, 22);
            this.textBoxIDZadania.TabIndex = 6;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.modułZarządzaniaPersonelemDataSet;
            // 
            // modułZarządzaniaPersonelemDataSet
            // 
            this.modułZarządzaniaPersonelemDataSet.DataSetName = "ModułZarządzaniaPersonelemDataSet";
            this.modułZarządzaniaPersonelemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelIDzadania
            // 
            this.labelIDzadania.AutoSize = true;
            this.labelIDzadania.Location = new System.Drawing.Point(92, 38);
            this.labelIDzadania.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDzadania.Name = "labelIDzadania";
            this.labelIDzadania.Size = new System.Drawing.Size(75, 17);
            this.labelIDzadania.TabIndex = 5;
            this.labelIDzadania.Text = "ID zadania";
            // 
            // OpisZadania
            // 
            this.OpisZadania.AutoSize = true;
            this.OpisZadania.Location = new System.Drawing.Point(89, 190);
            this.OpisZadania.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpisZadania.Name = "OpisZadania";
            this.OpisZadania.Size = new System.Drawing.Size(91, 17);
            this.OpisZadania.TabIndex = 4;
            this.OpisZadania.Text = "Opis zadania";
            // 
            // NazwaZadania
            // 
            this.NazwaZadania.AutoSize = true;
            this.NazwaZadania.Location = new System.Drawing.Point(79, 117);
            this.NazwaZadania.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazwaZadania.Name = "NazwaZadania";
            this.NazwaZadania.Size = new System.Drawing.Size(104, 17);
            this.NazwaZadania.TabIndex = 3;
            this.NazwaZadania.Text = "Nazwa zadania";
            // 
            // txtbNazwaZadania
            // 
            this.txtbNazwaZadania.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "nameTask", true));
            this.txtbNazwaZadania.Location = new System.Drawing.Point(11, 148);
            this.txtbNazwaZadania.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNazwaZadania.Name = "txtbNazwaZadania";
            this.txtbNazwaZadania.Size = new System.Drawing.Size(241, 22);
            this.txtbNazwaZadania.TabIndex = 2;
            this.txtbNazwaZadania.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNazwaZadania_KeyPress);
            // 
            // txtbOpisZadania
            // 
            this.txtbOpisZadania.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "description", true));
            this.txtbOpisZadania.Location = new System.Drawing.Point(11, 219);
            this.txtbOpisZadania.Margin = new System.Windows.Forms.Padding(4);
            this.txtbOpisZadania.Name = "txtbOpisZadania";
            this.txtbOpisZadania.Size = new System.Drawing.Size(241, 22);
            this.txtbOpisZadania.TabIndex = 1;
            this.txtbOpisZadania.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbOpisZadania_KeyPress);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.taskBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(263, 27);
            this.bindingNavigator1.TabIndex = 0;
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
            // buttonZapiszZadanie
            // 
            this.buttonZapiszZadanie.Location = new System.Drawing.Point(68, 277);
            this.buttonZapiszZadanie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZapiszZadanie.Name = "buttonZapiszZadanie";
            this.buttonZapiszZadanie.Size = new System.Drawing.Size(176, 28);
            this.buttonZapiszZadanie.TabIndex = 47;
            this.buttonZapiszZadanie.Text = "Zapisz";
            this.buttonZapiszZadanie.UseVisualStyleBackColor = true;
            this.buttonZapiszZadanie.Click += new System.EventHandler(this.buttonZapiszZadanie_Click);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(37, 225);
            this.textBoxOpis.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(241, 22);
            this.textBoxOpis.TabIndex = 46;
            this.textBoxOpis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOpis_KeyPress);
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(37, 159);
            this.textBoxNazwa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(241, 22);
            this.textBoxNazwa.TabIndex = 45;
            this.textBoxNazwa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazwa_KeyPress);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(136, 196);
            this.labelOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(37, 17);
            this.labelOpis.TabIndex = 44;
            this.labelOpis.Text = "Opis";
            // 
            // labelNazwa
            // 
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.Location = new System.Drawing.Point(129, 132);
            this.labelNazwa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Size = new System.Drawing.Size(50, 17);
            this.labelNazwa.TabIndex = 43;
            this.labelNazwa.Text = "Nazwa";
            // 
            // labelDodajZadanie
            // 
            this.labelDodajZadanie.AutoSize = true;
            this.labelDodajZadanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDodajZadanie.Location = new System.Drawing.Point(79, 87);
            this.labelDodajZadanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDodajZadanie.Name = "labelDodajZadanie";
            this.labelDodajZadanie.Size = new System.Drawing.Size(150, 25);
            this.labelDodajZadanie.TabIndex = 42;
            this.labelDodajZadanie.Text = "Dodaj zadanie";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(33, 26);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(42, 17);
            this.labelData.TabIndex = 41;
            this.labelData.Text = "Data:";
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Location = new System.Drawing.Point(768, 10);
            this.buttonWyloguj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(100, 28);
            this.buttonWyloguj.TabIndex = 54;
            this.buttonWyloguj.Text = "Wyloguj";
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            this.buttonWyloguj.Click += new System.EventHandler(this.buttonWyloguj_Click);
            // 
            // buttonPrzypisz
            // 
            this.buttonPrzypisz.Location = new System.Drawing.Point(451, 98);
            this.buttonPrzypisz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrzypisz.Name = "buttonPrzypisz";
            this.buttonPrzypisz.Size = new System.Drawing.Size(307, 98);
            this.buttonPrzypisz.TabIndex = 55;
            this.buttonPrzypisz.Text = "Przypisz zadanie";
            this.buttonPrzypisz.UseVisualStyleBackColor = true;
            this.buttonPrzypisz.Click += new System.EventHandler(this.buttonPrzypisz_Click);
            // 
            // labelData1
            // 
            this.labelData1.AutoSize = true;
            this.labelData1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData1.Location = new System.Drawing.Point(91, 21);
            this.labelData1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(69, 23);
            this.labelData1.TabIndex = 56;
            this.labelData1.Text = "label1";
            // 
            // buttonWyświetl
            // 
            this.buttonWyświetl.Location = new System.Drawing.Point(451, 225);
            this.buttonWyświetl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWyświetl.Name = "buttonWyświetl";
            this.buttonWyświetl.Size = new System.Drawing.Size(307, 94);
            this.buttonWyświetl.TabIndex = 57;
            this.buttonWyświetl.Text = "Wyświetl harmonogram";
            this.buttonWyświetl.UseVisualStyleBackColor = true;
            this.buttonWyświetl.Click += new System.EventHandler(this.buttonWyświetl_Click);
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // PanelMenadżera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 726);
            this.Controls.Add(this.buttonWyświetl);
            this.Controls.Add(this.labelData1);
            this.Controls.Add(this.buttonPrzypisz);
            this.Controls.Add(this.buttonWyloguj);
            this.Controls.Add(this.buttonEdytujPracownika);
            this.Controls.Add(this.labelListaPracowników);
            this.Controls.Add(this.buttonDodajPracownika);
            this.Controls.Add(this.labelListaZadań);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonZapiszZadanie);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelNazwa);
            this.Controls.Add(this.labelDodajZadanie);
            this.Controls.Add(this.labelData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelMenadżera";
            this.Text = "HarmonogramUprzywilejowany";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelMenadżera_FormClosing);
            this.Load += new System.EventHandler(this.HarmonogramUprzywilejowany_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modułZarządzaniaPersonelemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdytujPracownika;
        private System.Windows.Forms.Label labelListaPracowników;
        private System.Windows.Forms.Button buttonDodajPracownika;
        private System.Windows.Forms.Label labelListaZadań;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonZapiszZadanie;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.Label labelDodajZadanie;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label OpisZadania;
        private System.Windows.Forms.Label NazwaZadania;
        private System.Windows.Forms.TextBox txtbNazwaZadania;
        private System.Windows.Forms.TextBox txtbOpisZadania;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textBoxIDZadania;
        private System.Windows.Forms.Label labelIDzadania;
        private System.Windows.Forms.Button buttonModyfikujZadanie;

        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Button buttonPrzypisz;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.Button buttonWyświetl;
        private ModułZarządzaniaPersonelemDataSet modułZarządzaniaPersonelemDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private ModułZarządzaniaPersonelemDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
    }
}