#region Using
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

using VenditaVeicoliDllProject;
#endregion

namespace WindowsFormsAppProject
{
    public partial class frmAddVeicolo : Form
    {
        #region Variables
        BindingList<Veicolo> bindingListVeicoli;
        FormMain formMain;
        private string connectionString;
        string pathDataBase = "";
        string path = "";
        string file = "";
        bool picked = false;
        #endregion

        #region Form
        public frmAddVeicolo(BindingList<Veicolo> list, FormMain f)
        {
            InitializeComponent();
            bindingListVeicoli = list;
            this.formMain = f;
            pathDataBase = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.accdb";
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathDataBase;
        }

        private void FormDialogAggiungiVeicolo_Load(object sender, EventArgs e)
        {
            cmbTipoVeicolo.SelectedIndex = 0;
            cmbColore.SelectedIndex = 0;
            rdbKmZeroSì.Checked = true;
            rdbUsatoNo.Checked = true;
            numKmPercorsi.Minimum = 0;
            numKmPercorsi.Value = 0;
            numKmPercorsi.Enabled = false;
        }
        #endregion

        #region Buttons
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int index = 0;
            bool error = false;
            path = "img/NoImage.jpg";
            picked = true;
            if (picked)
            {
                bool usato;
                bool kmZero;
                if (rdbUsatoSì.Checked)
                {
                    usato = true;
                }
                else
                {
                    usato = false;
                }
                if (rdbKmZeroSì.Checked)
                {
                    kmZero = true;
                }
                else
                {
                    kmZero = false;
                }

                controlloErrore(error);
                
                if (error == true)
                {
                    MessageBox.Show("Errore nell'inserimento dei dati!");
                }
                else if (cmbTipoVeicolo.SelectedIndex == 0) //AUTO
                {
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    ClsDB.connection(connection, index);

                    path = "img/" + index + ".jpg";
                    File.Copy(file, path);

                    bindingListVeicoli.Add(new Auto(index, txtMarca.Text, txtModello.Text, cmbColore.Text, Convert.ToInt32(numCilindrata.Value), Convert.ToDouble(txtPotKW.Text), Convert.ToDateTime(dateImmatricolazione.Value.ToShortDateString()), usato, kmZero, Convert.ToInt32(numKmPercorsi.Value), Convert.ToInt32(numNumAirbag.Value), path));

                    ClsDB.createAuto(connection);

                    clsUtils.controlloMarca(txtMarca.Text);
                    clsUtils.controlloColore(cmbColore.Text);
                    formMain.salva();
                    connection.Close();
                    this.Close();
                }
                else //MOTO
                {
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    ClsDB.connection(connection, index);

                    path = "img/" + index + ".jpg";
                    File.Copy(file, "img/" + index + ".jpg");

                    bindingListVeicoli.Add(new Moto(index, txtMarca.Text, txtModello.Text, cmbColore.Text, Convert.ToInt32(numCilindrata.Value), Convert.ToDouble(txtPotKW.Text), Convert.ToDateTime(dateImmatricolazione.Value.ToShortDateString()), usato, kmZero, Convert.ToInt32(numKmPercorsi.Value), txtSella.Text, path));

                    ClsDB.createAuto(connection);

                    clsUtils.controlloMarca(txtMarca.Text);
                    clsUtils.controlloColore(cmbColore.Text);
                    formMain.salva();
                    connection.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Non è stata selezionata l'immagine da associare al veicolo");
            }
        }

        private void btnScegliFile_Click(object sender, EventArgs e)
        {
            ofdImg.ShowDialog();
            file = ofdImg.FileName;
            if ((file != "openFileDialog1") && (file != ""))
            {
                picked = true;
                path = file;
            }
            else
            {
                picked = false;
            }
            pcbVeicolo.ImageLocation = path;
        }
        #endregion

        #region CmbTipoVeicolo
        private void cmbTipoVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVeicolo.SelectedIndex == 0)
            {
                groupBoxCaratteristicheAuto.Visible = true;
                grpSella.Visible = false;
            }
            else
            {
                groupBoxCaratteristicheAuto.Visible = false;
                grpSella.Visible = true;
            }
        }
        #endregion

        #region Radio Buttons
        private void rdbKmZeroSì_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKmZeroSì.Checked)
            {
                numKmPercorsi.Minimum = 0;
                numKmPercorsi.Value = 0;
                numKmPercorsi.Enabled = false;
            }
            else
            {
                numKmPercorsi.Minimum = 1;
                numKmPercorsi.Value = 1;
                numKmPercorsi.Enabled = true;
            }
        }

        private void rdbUsatoSì_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUsatoSì.Checked && rdbKmZeroNo.Checked)
            {
                numKmPercorsi.Minimum = 1;
                numKmPercorsi.Value = 1;
                numKmPercorsi.Enabled = true;
                numKmPercorsi.Enabled = true;
            }
            else
            {
                if (rdbKmZeroSì.Checked)
                {
                    numKmPercorsi.Minimum = 0;
                    numKmPercorsi.Value = 0;
                    numKmPercorsi.Enabled = false;
                }
                else
                {
                    numKmPercorsi.Minimum = 1;
                    numKmPercorsi.Value = 1;
                    numKmPercorsi.Enabled = true;
                }
            }
        }
        #endregion

        #region TextChanged
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            lblMarca.Text = txtMarca.Text;
        }

        private void txtModello_TextChanged(object sender, EventArgs e)
        {
            lblModello.Text = txtModello.Text;
        }
        #endregion

        #region Other
        private void controlloErrore(bool error)
        {
            if (txtMarca.Text == "")
            {
                error = true;
            }
            if (txtModello.Text == "")
            {
                error = true;
            }
            if (txtPotKW.Text == "")
            {
                error = true;
            }
            try
            {
                int cilind = Convert.ToInt32(numCilindrata.Value);
            }
            catch (Exception)
            {
                error = true;
            }
            try
            {
                int kmp = Convert.ToInt32(numKmPercorsi.Value);
            }
            catch (Exception)
            {
                error = true;
            }
            if (cmbTipoVeicolo.SelectedIndex == 0)
            {
                //AUTO
                try
                {
                    int nAirbag = Convert.ToInt32(numNumAirbag.Value);
                }
                catch (Exception)
                {
                    error = true;
                }
            }
            else
            {
                //MOTO
                if (txtSella.Text == "")
                {
                    error = true;
                }
            }
        }
        #endregion
    }
}


