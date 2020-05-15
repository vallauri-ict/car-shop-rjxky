#region Using
using System;
using System.Xml.Serialization;
#endregion

namespace VenditaVeicoliDllProject
{
    [Serializable()]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Auto))]
    public abstract class Veicolo
    {
        #region Variables
        private int idVeicolo;
        private string marca;
        private string modello;
        private string colore;
        private int cilindrata;
        private double potenzaKw;
        private DateTime immatricolazione;
        private bool isUsato;
        private bool isKmZero;
        private int kmPercorsi;
        private string path;
        #endregion

        #region Veicolo
        public Veicolo()
        {
        }

        public Veicolo(int idVeicolo, string marca, string modello, string colore, int cilindrata, double potenzaKw, DateTime immatricolazione, bool isUsato, bool isKmZero, int kmPercorsi, string path)
        {
            this.IdVeicolo = idVeicolo;
            this.Marca = marca;
            this.Modello = modello;
            this.Colore = colore;
            this.Cilindrata = cilindrata;
            this.PotenzaKw = potenzaKw;
            this.Immatricolazione = immatricolazione;
            this.IsUsato = isUsato;
            this.IsKmZero = isKmZero;
            this.KmPercorsi = kmPercorsi;
            this.Path = path;

        }
        #endregion

        #region Properties
        public int IdVeicolo
        {
            get => idVeicolo; set => idVeicolo = value;
        }
        public string Marca
        {
            get => marca.ToUpper(); set => marca = value;
        }
        public string Modello
        {
            get => modello; set => modello = value;
        }
        public string Colore
        {
            get => colore; set => colore = value;
        }
        public int Cilindrata
        {
            get => cilindrata; set => cilindrata = value;
        }
        public double PotenzaKw
        {
            get => potenzaKw; set => potenzaKw = value;
        }
        public DateTime Immatricolazione
        {
            get => immatricolazione; set => immatricolazione = value;
        }
        public bool IsUsato
        {
            get => isUsato; set => isUsato = value;
        }
        public bool IsKmZero
        {
            get => isKmZero; set => isKmZero = value;
        }
        public int KmPercorsi
        {
            get => kmPercorsi; set => kmPercorsi = value;
        }
        public string Path
        {
            get => path; set => path = value;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            string retVal = $" {this.Marca} {this.Modello} - ({this.Immatricolazione.Year})";
            return retVal;
        }
        #endregion
    }
}
