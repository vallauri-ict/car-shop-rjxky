#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Threading;
#endregion

namespace VenditaVeicoliDllProject
{
    public class ClsDB
    {
        #region Creation
        public static void createAuto(OleDbConnection connection)
        {
            using (connection)
            {
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;

                command.CommandText = "INSERT INTO Veicoli (Tipologia, Marca, Modello, Colore, Cilindrata, PotenzaKw, Immatricolazione, IsUsato, IsKmZero, KmPercorsi, Informazioni, Immagine) VALUES" +
                    "(@tipologia, @marca, @modello, @colore, @cilindrata, @potenzakw, @immatricolazione, @isusato, @iskmzero, @iskmpercorsi, @informazioni, @immagine)";

                command.Parameters.Add(new OleDbParameter("@tipologia", OleDbType.VarChar, 255)).Value = "AUTO";
                command.Parameters.Add("@marca", OleDbType.VarChar, 255).Value = "FIAT";
                command.Parameters.Add("@modello", OleDbType.VarChar, 255).Value = "500";
                command.Parameters.Add("@colore", OleDbType.VarChar, 255).Value = "Bianco";
                command.Parameters.Add("@cilindrata", OleDbType.Integer).Value = 500;
                command.Parameters.Add("@potenzakw", OleDbType.Integer).Value = 150;
                command.Parameters.Add("@immatricolazione", OleDbType.Date).Value = (DateTime.Now).ToShortDateString();
                command.Parameters.Add("@isusato", OleDbType.Boolean).Value = false;
                command.Parameters.Add("@iskmzero", OleDbType.Boolean).Value = true;
                command.Parameters.Add("@kmpercorsi", OleDbType.Integer).Value = 0;
                command.Parameters.Add("@informazioni", OleDbType.VarChar, 255).Value = "4";
                command.Parameters.Add("@immagine", OleDbType.VarChar, 255).Value = "img/auto.jpg";

                command.Prepare();

                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("\nAUTO AGGIUNTA CORRETTAMENTE!");
                    Thread.Sleep(4000);
                }
                catch (OleDbException exc)
                {
                    Console.WriteLine("\n\n" + exc.Message);
                    Thread.Sleep(4000);
                    return;
                }
            }
        }

        public static void createMoto(OleDbConnection connection)
        {
            using (connection)
            {
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;

                command.CommandText = "INSERT INTO Veicoli (Tipologia, Marca, Modello, Colore, Cilindrata, PotenzaKw, Immatricolazione, IsUsato, IsKmZero, KmPercorsi, Informazioni, Immagine) VALUES" +
                    "(@tipologia, @marca, @modello, @colore, @cilindrata, @potenzakw, @immatricolazione, @isusato, @iskmzero, @iskmpercorsi, @informazioni, @immagine)";

                command.Parameters.Add(new OleDbParameter("@tipologia", OleDbType.VarChar, 255)).Value = "MOTO";
                command.Parameters.Add("@marca", OleDbType.VarChar, 255).Value = "HONDA";
                command.Parameters.Add("@modello", OleDbType.VarChar, 255).Value = "Tsunami";
                command.Parameters.Add("@colore", OleDbType.VarChar, 255).Value = "Blu";
                command.Parameters.Add("@cilindrata", OleDbType.Integer).Value = 550;
                command.Parameters.Add("@potenzakw", OleDbType.Integer).Value = 120;
                command.Parameters.Add("@immatricolazione", OleDbType.Date).Value = (DateTime.Now).ToShortDateString();
                command.Parameters.Add("@isusato", OleDbType.Boolean).Value = false;
                command.Parameters.Add("@iskmzero", OleDbType.Boolean).Value = true;
                command.Parameters.Add("@kmpercorsi", OleDbType.Integer).Value = 0;
                command.Parameters.Add("@informazioni", OleDbType.VarChar, 255).Value = "Cavallino";
                command.Parameters.Add("@immagine", OleDbType.VarChar, 255).Value = "img/moto.jpg";
                command.Prepare();
                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("\nMOTO AGGIUNTA CORRETTAMENTE");
                    Thread.Sleep(4000);
                }
                catch (OleDbException ex)
                {
                    Console.WriteLine("\n\n" + ex.Message);
                    Thread.Sleep(4000);
                    return;
                }
            }
        }
        #endregion

        #region Connection
        public static void connection(OleDbConnection connection,int index)
        {
            
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT IdVeicolo FROM Veicoli";

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    index = reader.GetInt32(0);
                }
                index++;
            }
        }
        #endregion
    }
}