﻿#region Using
using System;
#endregion

namespace VenditaVeicoliDllProject
{
    public class Auto : Veicolo
    {
        #region Auto
        private int numAirbag;

        public Auto(int idVeicolo, string marca, string modello, string colore, int cilindrata, double potenzaKw, DateTime immatricolazione, bool isUsato, bool isKmZero, int kmPercorsi, int numAirbag, string path) : base(idVeicolo, marca, modello, colore, cilindrata, potenzaKw, immatricolazione, isUsato, isKmZero, kmPercorsi, path)
        {
            this.NumAirbag = numAirbag;
        }

        public int NumAirbag
        {
            get => numAirbag; set => numAirbag = value;
        }

        public override string ToString()
        {
            return $"Auto: { base.ToString()} - {this.NumAirbag} Airbag";
        }
        #endregion
    }
}