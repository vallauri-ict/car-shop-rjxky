namespace WindowsFormsAppProject
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tsVeicoli = new System.Windows.Forms.ToolStrip();
            this.tsbNuovo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalva = new System.Windows.Forms.ToolStripButton();
            this.tsbModifica = new System.Windows.Forms.ToolStripButton();
            this.tsbElimina = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbJson = new System.Windows.Forms.ToolStripButton();
            this.tsbWord = new System.Windows.Forms.ToolStripButton();
            this.tsbExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbHTMLPage = new System.Windows.Forms.ToolStripButton();
            this.lstVeicoli = new System.Windows.Forms.ListBox();
            this.tsVeicoli.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsVeicoli
            // 
            this.tsVeicoli.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tsVeicoli.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuovo,
            this.tsbSalva,
            this.tsbModifica,
            this.tsbElimina,
            this.toolStripSeparator1,
            this.tsbJson,
            this.tsbWord,
            this.tsbExcel,
            this.tsbHTMLPage});
            this.tsVeicoli.Location = new System.Drawing.Point(0, 0);
            this.tsVeicoli.Name = "tsVeicoli";
            this.tsVeicoli.Size = new System.Drawing.Size(481, 25);
            this.tsVeicoli.TabIndex = 1;
            this.tsVeicoli.Text = "toolStrip1";
            // 
            // tsbNuovo
            // 
            this.tsbNuovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuovo.Image")));
            this.tsbNuovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuovo.Name = "tsbNuovo";
            this.tsbNuovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuovo.Text = "&New";
            this.tsbNuovo.Click += new System.EventHandler(this.tsbNuovo_Click);
            // 
            // tsbSalva
            // 
            this.tsbSalva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalva.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalva.Image")));
            this.tsbSalva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalva.Name = "tsbSalva";
            this.tsbSalva.Size = new System.Drawing.Size(23, 22);
            this.tsbSalva.Text = "&Save";
            this.tsbSalva.Click += new System.EventHandler(this.tsbSalva_Click);
            // 
            // tsbModifica
            // 
            this.tsbModifica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModifica.Image = ((System.Drawing.Image)(resources.GetObject("tsbModifica.Image")));
            this.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifica.Name = "tsbModifica";
            this.tsbModifica.Size = new System.Drawing.Size(23, 22);
            this.tsbModifica.Text = "&Edit";
            this.tsbModifica.Click += new System.EventHandler(this.tsbModifica_Click);
            // 
            // tsbElimina
            // 
            this.tsbElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbElimina.Image = ((System.Drawing.Image)(resources.GetObject("tsbElimina.Image")));
            this.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbElimina.Name = "tsbElimina";
            this.tsbElimina.Size = new System.Drawing.Size(23, 22);
            this.tsbElimina.Text = "&Delete";
            this.tsbElimina.Click += new System.EventHandler(this.tsbElimina_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbJson
            // 
            this.tsbJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbJson.Image = ((System.Drawing.Image)(resources.GetObject("tsbJson.Image")));
            this.tsbJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJson.Name = "tsbJson";
            this.tsbJson.Size = new System.Drawing.Size(23, 22);
            this.tsbJson.Text = "Export to &Json";
            this.tsbJson.Click += new System.EventHandler(this.tsbJson_Click);
            // 
            // tsbWord
            // 
            this.tsbWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWord.Image = ((System.Drawing.Image)(resources.GetObject("tsbWord.Image")));
            this.tsbWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWord.Name = "tsbWord";
            this.tsbWord.Size = new System.Drawing.Size(23, 22);
            this.tsbWord.Text = "Export to &Word";
            this.tsbWord.Click += new System.EventHandler(this.tsbWord_Click);
            // 
            // tsbExcel
            // 
            this.tsbExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcel.Image")));
            this.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Size = new System.Drawing.Size(23, 22);
            this.tsbExcel.Text = "Export to E&xcel";
            this.tsbExcel.Click += new System.EventHandler(this.tsbExcel_Click);
            // 
            // tsbHTMLPage
            // 
            this.tsbHTMLPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHTMLPage.Image = ((System.Drawing.Image)(resources.GetObject("tsbHTMLPage.Image")));
            this.tsbHTMLPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHTMLPage.Name = "tsbHTMLPage";
            this.tsbHTMLPage.Size = new System.Drawing.Size(23, 22);
            this.tsbHTMLPage.Text = "Export to &HTML";
            this.tsbHTMLPage.Click += new System.EventHandler(this.tsbHTMLPage_Click);
            // 
            // lstVeicoli
            // 
            this.lstVeicoli.BackColor = System.Drawing.Color.LightGreen;
            this.lstVeicoli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVeicoli.FormattingEnabled = true;
            this.lstVeicoli.Location = new System.Drawing.Point(0, 25);
            this.lstVeicoli.Name = "lstVeicoli";
            this.lstVeicoli.Size = new System.Drawing.Size(481, 362);
            this.lstVeicoli.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 387);
            this.Controls.Add(this.lstVeicoli);
            this.Controls.Add(this.tsVeicoli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "CAR SHOP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tsVeicoli.ResumeLayout(false);
            this.tsVeicoli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsVeicoli;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbElimina;
        private System.Windows.Forms.ToolStripButton tsbJson;
        private System.Windows.Forms.ToolStripButton tsbModifica;
        private System.Windows.Forms.ToolStripButton tsbWord;
        private System.Windows.Forms.ToolStripButton tsbExcel;
        private System.Windows.Forms.ListBox lstVeicoli;
        private System.Windows.Forms.ToolStripButton tsbNuovo;
        private System.Windows.Forms.ToolStripButton tsbSalva;
        private System.Windows.Forms.ToolStripButton tsbHTMLPage;
    }
}

