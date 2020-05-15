#region Using
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using Microsoft.VisualBasic;

using VenditaVeicoliDllProject;
#endregion

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        #region Initialization
        private string connectionString;
        BindingList<Veicolo> bindingListVeicoli;
        string path;
        OleDbConnection connection;
        #endregion

        #region FormMethods
        public FormMain()
        {
            InitializeComponent();

            bindingListVeicoli = new BindingList<Veicolo>();

            path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.accdb";
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;

            connection = new OleDbConnection(connectionString);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lstVeicoli.DataSource = bindingListVeicoli;
            if (connectionString != null)
            {
                using (connection)
                {
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Veicoli", connection);
                    connection.Open();
                    try
                    {
                        OleDbDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                if (reader.GetString(1) == "MOTO")
                                {
                                    Moto m = new Moto(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), Convert.ToDouble(reader.GetInt32(6)), reader.GetDateTime(7),
                                        reader.GetBoolean(8), reader.GetBoolean(9), reader.GetInt32(10), reader.GetString(11), reader.GetString(12));
                                    bindingListVeicoli.Add(m);
                                    clsUtils.controlloMarca(reader.GetString(2));
                                    clsUtils.controlloColore(reader.GetString(4));
                                }
                                else
                                {
                                    Auto a = new Auto(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), Convert.ToDouble(reader.GetInt32(6)), reader.GetDateTime(7),
                                        reader.GetBoolean(8), reader.GetBoolean(9), reader.GetInt32(10), Convert.ToInt32(reader.GetString(11)), reader.GetString(12));
                                    bindingListVeicoli.Add(a);
                                    clsUtils.controlloMarca(reader.GetString(2));
                                    clsUtils.controlloColore(reader.GetString(4));
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nessuna riga trovata!");
                        }
                        object[] vet = { "IdVeicolo", "Marca", "Modello", "Colore", "Cilindrata", "PotenzaKw", "Immatricolazione", "IsUsato", "IsKmZero", "KmPercorsi" };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Impostare la stringa di connessione");
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Vuoi davvero uscire?", "Attenzione!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                salva();
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region ToolStrip Methods
        private void tsbNuovo_Click(object sender, EventArgs e)
        {
            frmAddVeicolo dialogAggiungi = new frmAddVeicolo(bindingListVeicoli, this);
            dialogAggiungi.ShowDialog();
        }

        private void tsbSalva_Click(object sender, EventArgs e)
        {
            salva();
        }

        public void salva()
        {
            using (StreamWriter sw = new StreamWriter("veicoli.dat", false))
            {
                string s = null;
                for (int i = 0; i < bindingListVeicoli.Count; i++)
                {
                    if (bindingListVeicoli[i].GetType().ToString().Contains("Moto"))
                    {
                        s = "MOTO |" + bindingListVeicoli[i].IdVeicolo + "|" + bindingListVeicoli[i].Marca + "|" + bindingListVeicoli[i].Modello + "|" + bindingListVeicoli[i].Colore + "|" + bindingListVeicoli[i].Cilindrata + "|" + bindingListVeicoli[i].PotenzaKw + "|" + bindingListVeicoli[i].Immatricolazione.ToShortDateString() + "|" + bindingListVeicoli[i].IsUsato + "|" + bindingListVeicoli[i].IsKmZero + "|" + bindingListVeicoli[i].KmPercorsi + "|" + (bindingListVeicoli[i] as Moto).MarcaSella + "|" + bindingListVeicoli[i].Path;
                        sw.WriteLine(s);
                    }
                    else
                    {
                        s = "AUTO |" + bindingListVeicoli[i].IdVeicolo + "|" + bindingListVeicoli[i].Marca + "|" + bindingListVeicoli[i].Modello + "|" + bindingListVeicoli[i].Colore + "|" + bindingListVeicoli[i].Cilindrata + "|" + bindingListVeicoli[i].PotenzaKw + "|" + bindingListVeicoli[i].Immatricolazione.ToShortDateString() + "|" + bindingListVeicoli[i].IsUsato + "|" + bindingListVeicoli[i].IsKmZero + "|" + bindingListVeicoli[i].KmPercorsi + "|" + (bindingListVeicoli[i] as Auto).NumAirbag + "|" + bindingListVeicoli[i].Path;
                        sw.WriteLine(s);
                    }
                }
            }
        }

        private void tsbModifica_Click(object sender, EventArgs e)
        {
            try
            {
                int pos;
                OleDbConnection connection = new OleDbConnection(connectionString);

                pos = Convert.ToInt32(Interaction.InputBox("Inserire l'ID del veicolo da modificare", "Modifica veicolo", "ID veicolo da modificare"));
                using (connection)
                {
                    OleDbCommand command = new OleDbCommand("", connection);
                    connection.Open();
                    command.Parameters.Add("@pos", OleDbType.Integer).Value = pos;
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbElimina_Click(object sender, EventArgs e)
        {
            try
            {
                int posiz = Convert.ToInt32(Interaction.InputBox("Inserire l'ID del veicolo da eliminare", "Elimina veicolo", "ID veicolo da eliminare"));
                OleDbConnection con = new OleDbConnection(connectionString);
                using (con)
                {
                    OleDbCommand command = new OleDbCommand("DELETE FROM Veicoli WHERE IdVeicolo=@pos", con);
                    con.Open();
                    command.Parameters.Add("@pos", OleDbType.Integer).Value = posiz;
                    try
                    {
                        command.ExecuteNonQuery();
                        bool state = elimina(posiz);
                        if (state)
                        {
                            MessageBox.Show("Veicolo eliminato correttamente");
                        }
                        else
                        {
                            MessageBox.Show("Id errato");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool elimina(int posiz)
        {
            int i = 0;
            bool trovato = false;
            while ((!trovato) && (i < bindingListVeicoli.Count))
            {
                if (bindingListVeicoli[i].IdVeicolo == posiz)
                {
                    if (bindingListVeicoli[i].Path == "img/NoImage.jpg")
                    {
                        bindingListVeicoli.RemoveAt(i);
                        return true;
                    }
                    else
                    {
                        File.Delete(bindingListVeicoli[i].Path);
                        bindingListVeicoli.RemoveAt(i);
                        return true;
                    }
                }
                else
                {
                    i++;
                }
            }
            return false;
        }

        private void tsbJson_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.json";
                Utils.SerializeToJson(bindingListVeicoli, filepath);
                DialogResult dg = MessageBox.Show("Documento creato. Vuoi aprirlo?", "JSON", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dg == DialogResult.Yes)
                {
                    Process.Start(filepath);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tsbHTMLPage_Click(object sender, EventArgs e)
        {
            string html = File.ReadAllText(".\\www\\index-skeleton.html");
            string item = "";
            int index = 0;
            for (int i = 0; i < bindingListVeicoli.Count; i++)
            {
                if (bindingListVeicoli[i] is Auto)
                {
                    item += "<div class='auto' id=" + index + ">";
                    item += "<img src='auto.jpg'>";
                    item += "<div class='auto' id=" + index + ">" + bindingListVeicoli[i].Marca + " " + bindingListVeicoli[i].Modello + "\n" + bindingListVeicoli[i].Colore + "</div>" + "</div>";
                    index++;
                }
                else
                {
                    item += "<div class='moto' id=" + index + ">";
                    item += "<img src='moto.jpg'>";
                    item += "<div class='moto' id=" + index + ">" + bindingListVeicoli[i].Marca + " " + bindingListVeicoli[i].Modello + "\n" + bindingListVeicoli[i].Colore + "</div>" + "</div>";
                    index++;
                }
            }
            html = html.Replace("{{mainContent}}", item);
            File.WriteAllText(".\\www\\index.html", html);
            Process.Start(".\\www\\index.html");
        }

        private void tsbWord_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.createWordDoc();
                DialogResult d = MessageBox.Show("Documento creato. Vuoi aprirlo?", "Word", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    string filepath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.docx";
                    Process.Start(filepath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tsbExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.csv";
                Utils.SerializeToCsv(bindingListVeicoli, filepath);
                DialogResult dg = MessageBox.Show("Documento creato. Vuoi aprirlo?", "Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dg == DialogResult.Yes)
                {
                    Process.Start(filepath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}