namespace WindowsFormsAppProject
{
    partial class frmAddVeicolo
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
            this.cmbTipoVeicolo = new System.Windows.Forms.ComboBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.groupBoxCaratteristicheVeicolo = new System.Windows.Forms.GroupBox();
            this.numCilindrata = new System.Windows.Forms.NumericUpDown();
            this.numKmPercorsi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.grpKmZero = new System.Windows.Forms.GroupBox();
            this.rdbKmZeroSì = new System.Windows.Forms.RadioButton();
            this.rdbKmZeroNo = new System.Windows.Forms.RadioButton();
            this.grpUsato = new System.Windows.Forms.GroupBox();
            this.rdbUsatoSì = new System.Windows.Forms.RadioButton();
            this.rdbUsatoNo = new System.Windows.Forms.RadioButton();
            this.dateImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPotKW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCaratteristicheAuto = new System.Windows.Forms.GroupBox();
            this.numNumAirbag = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroAirbag = new System.Windows.Forms.Label();
            this.grpSella = new System.Windows.Forms.GroupBox();
            this.txtSella = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.btnImg = new System.Windows.Forms.Button();
            this.pcbVeicolo = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModello = new System.Windows.Forms.Label();
            this.groupBoxCaratteristicheVeicolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCilindrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmPercorsi)).BeginInit();
            this.grpKmZero.SuspendLayout();
            this.grpUsato.SuspendLayout();
            this.groupBoxCaratteristicheAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumAirbag)).BeginInit();
            this.grpSella.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVeicolo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoVeicolo
            // 
            this.cmbTipoVeicolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVeicolo.FormattingEnabled = true;
            this.cmbTipoVeicolo.Items.AddRange(new object[] {
            "AUTO",
            "MOTO"});
            this.cmbTipoVeicolo.Location = new System.Drawing.Point(82, 12);
            this.cmbTipoVeicolo.Name = "cmbTipoVeicolo";
            this.cmbTipoVeicolo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVeicolo.TabIndex = 0;
            this.cmbTipoVeicolo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVeicolo_SelectedIndexChanged);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(116, 403);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(197, 403);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // groupBoxCaratteristicheVeicolo
            // 
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.numCilindrata);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.numKmPercorsi);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.label7);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.grpKmZero);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.grpUsato);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.dateImmatricolazione);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.label6);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.txtPotKW);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.label5);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.cmbColore);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.label4);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.label3);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.txtModello);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.txtMarca);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.label2);
            this.groupBoxCaratteristicheVeicolo.Controls.Add(this.label1);
            this.groupBoxCaratteristicheVeicolo.Location = new System.Drawing.Point(12, 51);
            this.groupBoxCaratteristicheVeicolo.Name = "groupBoxCaratteristicheVeicolo";
            this.groupBoxCaratteristicheVeicolo.Size = new System.Drawing.Size(260, 253);
            this.groupBoxCaratteristicheVeicolo.TabIndex = 3;
            this.groupBoxCaratteristicheVeicolo.TabStop = false;
            this.groupBoxCaratteristicheVeicolo.Text = "Caratteristiche veicolo";
            // 
            // numCilindrata
            // 
            this.numCilindrata.Location = new System.Drawing.Point(104, 89);
            this.numCilindrata.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numCilindrata.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCilindrata.Name = "numCilindrata";
            this.numCilindrata.Size = new System.Drawing.Size(100, 20);
            this.numCilindrata.TabIndex = 25;
            this.numCilindrata.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numKmPercorsi
            // 
            this.numKmPercorsi.Location = new System.Drawing.Point(104, 221);
            this.numKmPercorsi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKmPercorsi.Name = "numKmPercorsi";
            this.numKmPercorsi.Size = new System.Drawing.Size(100, 20);
            this.numKmPercorsi.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Km percorsi";
            // 
            // grpKmZero
            // 
            this.grpKmZero.Controls.Add(this.rdbKmZeroSì);
            this.grpKmZero.Controls.Add(this.rdbKmZeroNo);
            this.grpKmZero.Location = new System.Drawing.Point(111, 161);
            this.grpKmZero.Name = "grpKmZero";
            this.grpKmZero.Size = new System.Drawing.Size(93, 45);
            this.grpKmZero.TabIndex = 22;
            this.grpKmZero.TabStop = false;
            this.grpKmZero.Text = "KmZero";
            // 
            // rdbKmZeroSì
            // 
            this.rdbKmZeroSì.AutoSize = true;
            this.rdbKmZeroSì.Checked = true;
            this.rdbKmZeroSì.Location = new System.Drawing.Point(6, 19);
            this.rdbKmZeroSì.Name = "rdbKmZeroSì";
            this.rdbKmZeroSì.Size = new System.Drawing.Size(34, 17);
            this.rdbKmZeroSì.TabIndex = 18;
            this.rdbKmZeroSì.TabStop = true;
            this.rdbKmZeroSì.Text = "Sì";
            this.rdbKmZeroSì.UseVisualStyleBackColor = true;
            this.rdbKmZeroSì.CheckedChanged += new System.EventHandler(this.rdbKmZeroSì_CheckedChanged);
            // 
            // rdbKmZeroNo
            // 
            this.rdbKmZeroNo.AutoSize = true;
            this.rdbKmZeroNo.Location = new System.Drawing.Point(46, 19);
            this.rdbKmZeroNo.Name = "rdbKmZeroNo";
            this.rdbKmZeroNo.Size = new System.Drawing.Size(39, 17);
            this.rdbKmZeroNo.TabIndex = 19;
            this.rdbKmZeroNo.TabStop = true;
            this.rdbKmZeroNo.Text = "No";
            this.rdbKmZeroNo.UseVisualStyleBackColor = true;
            // 
            // grpUsato
            // 
            this.grpUsato.Controls.Add(this.rdbUsatoSì);
            this.grpUsato.Controls.Add(this.rdbUsatoNo);
            this.grpUsato.Location = new System.Drawing.Point(9, 161);
            this.grpUsato.Name = "grpUsato";
            this.grpUsato.Size = new System.Drawing.Size(93, 45);
            this.grpUsato.TabIndex = 21;
            this.grpUsato.TabStop = false;
            this.grpUsato.Text = "Usato";
            // 
            // rdbUsatoSì
            // 
            this.rdbUsatoSì.AutoSize = true;
            this.rdbUsatoSì.Location = new System.Drawing.Point(6, 19);
            this.rdbUsatoSì.Name = "rdbUsatoSì";
            this.rdbUsatoSì.Size = new System.Drawing.Size(34, 17);
            this.rdbUsatoSì.TabIndex = 18;
            this.rdbUsatoSì.TabStop = true;
            this.rdbUsatoSì.Text = "Sì";
            this.rdbUsatoSì.UseVisualStyleBackColor = true;
            this.rdbUsatoSì.CheckedChanged += new System.EventHandler(this.rdbUsatoSì_CheckedChanged);
            // 
            // rdbUsatoNo
            // 
            this.rdbUsatoNo.AutoSize = true;
            this.rdbUsatoNo.Checked = true;
            this.rdbUsatoNo.Location = new System.Drawing.Point(46, 19);
            this.rdbUsatoNo.Name = "rdbUsatoNo";
            this.rdbUsatoNo.Size = new System.Drawing.Size(39, 17);
            this.rdbUsatoNo.TabIndex = 19;
            this.rdbUsatoNo.TabStop = true;
            this.rdbUsatoNo.Text = "No";
            this.rdbUsatoNo.UseVisualStyleBackColor = true;
            // 
            // dateImmatricolazione
            // 
            this.dateImmatricolazione.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateImmatricolazione.Location = new System.Drawing.Point(104, 135);
            this.dateImmatricolazione.Name = "dateImmatricolazione";
            this.dateImmatricolazione.Size = new System.Drawing.Size(100, 20);
            this.dateImmatricolazione.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Immatricolazione";
            // 
            // txtPotKW
            // 
            this.txtPotKW.Location = new System.Drawing.Point(104, 112);
            this.txtPotKW.Name = "txtPotKW";
            this.txtPotKW.Size = new System.Drawing.Size(100, 20);
            this.txtPotKW.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Potenza kW";
            // 
            // cmbColore
            // 
            this.cmbColore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "Bianco",
            "Nero",
            "Rosso",
            "Blu",
            "Verde",
            "Giallo",
            "Arancione",
            "Rosa",
            "Fucsia",
            "Ciano",
            "Azzurro",
            "Ocra"});
            this.cmbColore.Location = new System.Drawing.Point(104, 66);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(100, 21);
            this.cmbColore.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cilindrata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colore";
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(104, 44);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(100, 20);
            this.txtModello.TabIndex = 7;
            this.txtModello.TextChanged += new System.EventHandler(this.txtModello_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(104, 22);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 6;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modello";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // groupBoxCaratteristicheAuto
            // 
            this.groupBoxCaratteristicheAuto.Controls.Add(this.numNumAirbag);
            this.groupBoxCaratteristicheAuto.Controls.Add(this.lblNumeroAirbag);
            this.groupBoxCaratteristicheAuto.Location = new System.Drawing.Point(12, 310);
            this.groupBoxCaratteristicheAuto.Name = "groupBoxCaratteristicheAuto";
            this.groupBoxCaratteristicheAuto.Size = new System.Drawing.Size(260, 58);
            this.groupBoxCaratteristicheAuto.TabIndex = 4;
            this.groupBoxCaratteristicheAuto.TabStop = false;
            this.groupBoxCaratteristicheAuto.Text = "Auto";
            // 
            // numNumAirbag
            // 
            this.numNumAirbag.Location = new System.Drawing.Point(104, 25);
            this.numNumAirbag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumAirbag.Name = "numNumAirbag";
            this.numNumAirbag.Size = new System.Drawing.Size(100, 20);
            this.numNumAirbag.TabIndex = 26;
            this.numNumAirbag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumeroAirbag
            // 
            this.lblNumeroAirbag.AutoSize = true;
            this.lblNumeroAirbag.Location = new System.Drawing.Point(6, 27);
            this.lblNumeroAirbag.Name = "lblNumeroAirbag";
            this.lblNumeroAirbag.Size = new System.Drawing.Size(87, 13);
            this.lblNumeroAirbag.TabIndex = 0;
            this.lblNumeroAirbag.Text = "Numero di airbag";
            // 
            // grpSella
            // 
            this.grpSella.Controls.Add(this.txtSella);
            this.grpSella.Controls.Add(this.label8);
            this.grpSella.Location = new System.Drawing.Point(12, 310);
            this.grpSella.Name = "grpSella";
            this.grpSella.Size = new System.Drawing.Size(260, 58);
            this.grpSella.TabIndex = 27;
            this.grpSella.TabStop = false;
            this.grpSella.Text = "Moto";
            this.grpSella.Visible = false;
            // 
            // txtSella
            // 
            this.txtSella.Location = new System.Drawing.Point(104, 25);
            this.txtSella.Name = "txtSella";
            this.txtSella.Size = new System.Drawing.Size(100, 20);
            this.txtSella.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marca Sella";
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "openFileDialog1";
            this.ofdImg.Filter = "Image Files(*.JPG)|*.JPG";
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(12, 374);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(260, 23);
            this.btnImg.TabIndex = 9;
            this.btnImg.Text = "INSERISCI IMMAGINE";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnScegliFile_Click);
            // 
            // pcbVeicolo
            // 
            this.pcbVeicolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbVeicolo.Location = new System.Drawing.Point(304, 76);
            this.pcbVeicolo.Name = "pcbVeicolo";
            this.pcbVeicolo.Size = new System.Drawing.Size(275, 228);
            this.pcbVeicolo.TabIndex = 28;
            this.pcbVeicolo.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(304, 311);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 13);
            this.lblMarca.TabIndex = 29;
            // 
            // lblModello
            // 
            this.lblModello.AutoSize = true;
            this.lblModello.Location = new System.Drawing.Point(304, 328);
            this.lblModello.Name = "lblModello";
            this.lblModello.Size = new System.Drawing.Size(0, 13);
            this.lblModello.TabIndex = 30;
            // 
            // frmAddVeicolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.CancelButton = this.btnAnnulla;
            this.ClientSize = new System.Drawing.Size(591, 434);
            this.Controls.Add(this.lblModello);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pcbVeicolo);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.grpSella);
            this.Controls.Add(this.groupBoxCaratteristicheAuto);
            this.Controls.Add(this.groupBoxCaratteristicheVeicolo);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.cmbTipoVeicolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddVeicolo";
            this.Text = "AGGIUNGI VEICOLO";
            this.Load += new System.EventHandler(this.FormDialogAggiungiVeicolo_Load);
            this.groupBoxCaratteristicheVeicolo.ResumeLayout(false);
            this.groupBoxCaratteristicheVeicolo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCilindrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmPercorsi)).EndInit();
            this.grpKmZero.ResumeLayout(false);
            this.grpKmZero.PerformLayout();
            this.grpUsato.ResumeLayout(false);
            this.grpUsato.PerformLayout();
            this.groupBoxCaratteristicheAuto.ResumeLayout(false);
            this.groupBoxCaratteristicheAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumAirbag)).EndInit();
            this.grpSella.ResumeLayout(false);
            this.grpSella.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVeicolo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVeicolo;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.GroupBox groupBoxCaratteristicheVeicolo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.DateTimePicker dateImmatricolazione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbUsatoNo;
        private System.Windows.Forms.RadioButton rdbUsatoSì;
        private System.Windows.Forms.GroupBox grpKmZero;
        private System.Windows.Forms.RadioButton rdbKmZeroSì;
        private System.Windows.Forms.RadioButton rdbKmZeroNo;
        private System.Windows.Forms.GroupBox grpUsato;
        private System.Windows.Forms.NumericUpDown numKmPercorsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numCilindrata;
        private System.Windows.Forms.GroupBox groupBoxCaratteristicheAuto;
        private System.Windows.Forms.NumericUpDown numNumAirbag;
        private System.Windows.Forms.Label lblNumeroAirbag;
        private System.Windows.Forms.GroupBox grpSella;
        private System.Windows.Forms.TextBox txtSella;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog ofdImg;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.TextBox txtPotKW;
        private System.Windows.Forms.PictureBox pcbVeicolo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModello;
    }
}