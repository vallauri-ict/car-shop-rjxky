#region Using
using System;
#endregion

namespace VenditaVeicoliDllProject
{
    public class Moto : Veicolo
    {
        #region Moto
        private string marcaSella;

        public Moto(int idVeicolo, string marca, string modello, string colore, int cilindrata, double potenzaKw, DateTime immatricolazione, bool isUsato, bool isKmZero, int kmPercorsi, string marcaSella, string path) : base(idVeicolo, marca, modello, colore, cilindrata, potenzaKw, immatricolazione, isUsato, isKmZero, kmPercorsi, path)
        {
            this.MarcaSella = marcaSella;
        }

        public string MarcaSella
        {
            get => marcaSella; set => marcaSella = value;
        }

        public override string ToString()
        {
            return $"Moto: {base.ToString()} - Sella {this.MarcaSella}";
        }
        #endregion
    }
}