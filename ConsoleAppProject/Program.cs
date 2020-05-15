#region Using
using System;
using System.Data.OleDb;
using System.IO;
using System.Threading;

using VenditaVeicoliDllProject;
#endregion

namespace CarShopConsoleProject
{
    public class Program
    {
        #region Initialization
        public static string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.accdb";
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
        #endregion

        #region Main
        static void Main(string[] args)
        {
            char scelta;
            do
            {
                menu();
                Console.Write("SCELTA: ");
                scelta = Console.ReadKey().KeyChar;
                switch (scelta)
                {
                    case '1':
                        {
                            createTable();
                            break;
                        }
                    case '2':
                        {
                            addAuto();
                            break;
                        }
                    case '3':
                        {
                            addMoto();
                            break;
                        }
                    case '4':
                        {
                            visualizzaVeicoli();
                            break;
                        }
                    case '5':
                        {
                            Utils.createWordDoc();
                            break;
                        }
                    case '6':
                        {
                            deleteRecords();
                            break;
                        }
                    case '7':
                        {
                            deleteTable();
                            break;
                        }
                }
            }
            while (scelta != 'X' && scelta != 'x');
        }
        #endregion

        #region Menu
        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("\t*** CAR SHOP - DB MANAGEMENT ***\n");
            Console.WriteLine("1 - CREA TABELLA");
            Console.WriteLine("2 - AGGIUNGI AUTO");
            Console.WriteLine("3 - AGGIUNGI MOTO");
            Console.WriteLine("4 - VISUALIZZA VEICOLI");
            Console.WriteLine("5 - ESPORTA SU WORD");
            Console.WriteLine("6 - CANCELLA RECORD TABELLA");
            Console.WriteLine("7 - CANCELLA TABELLA");
            Console.WriteLine("\nX - ESCI\n");
        }
        #endregion

        #region Menu Methods
        private static void createTable()
        {
            if (connectionString != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                using (connection)
                {
                    connection.Open();

                    OleDbCommand odbCommand = new OleDbCommand();
                    odbCommand.Connection = connection;

                    try
                    {
                        odbCommand.CommandText = @"CREATE TABLE Veicoli(
                                            IdVeicolo INT NOT NULL PRIMARY KEY, 
                                            Tipologia VARCHAR(255) NOT NULL, 
                                            Marca VARCHAR(255) NOT NULL, 
                                            Modello VARCHAR(255) NOT NULL, 
                                            Colore VARCHAR(255) NOT NULL, 
                                            Cilindrata INT NOT NULL, 
                                            PotenzaKw INT NOT NULL, 
                                            Immatricolazione DATE NOT NULL, 
                                            IsUsato BIT NOT NULL, 
                                            IsKmZero BIT NOT NULL, 
                                            KmPercorsi INT NOT NULL, 
                                            Informazioni VARCHAR(255) NOT NULL, 
                                            Immagine VARCHAR(255) NOT NULL)";
                        odbCommand.ExecuteNonQuery();
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("\n\n" + ex.Message);
                        Thread.Sleep(4000);
                        return;
                    }

                    Console.WriteLine("\n\nTABELLA CREATA CORRETTAMENTE!");
                    Thread.Sleep(2000);
                }
            }
        }

        private static void addAuto()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            ClsDB.createAuto(connection);
        }

        private static void addMoto()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            ClsDB.createMoto(connection);
        }

        private static void visualizzaVeicoli()
        {
            if (connectionString != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                using (connection)
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand("SELECT * FROM Veicoli", connection);

                    try
                    {
                        OleDbDataReader exeReader = command.ExecuteReader();

                        if (exeReader.HasRows)
                        {
                            Console.WriteLine("\n");
                            while (exeReader.Read())
                            {
                                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} | {10} | {11} | {12}",
                                    exeReader.GetInt32(0), exeReader.GetString(1), exeReader.GetString(2), exeReader.GetString(3), exeReader.GetString(4), exeReader.GetInt32(5), exeReader.GetInt32(6),
                                    exeReader.GetDateTime(7).ToShortDateString(), exeReader.GetBoolean(8), exeReader.GetBoolean(9), exeReader.GetInt32(10), exeReader.GetString(11),
                                    exeReader.GetString(12));
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\nIL DATABASE NON CONTIENE VEICOLI!");
                        }
                        exeReader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n{ex.Message}");
                    }
                }
                Thread.Sleep(8000);
            }
        }

        private static void deleteRecords()
        {
            if (connectionString != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                using (connection)
                {
                    connection.Open();

                    OleDbCommand com = new OleDbCommand("DELETE FROM Veicoli", connection);
                    try
                    {
                        com.ExecuteNonQuery();
                        Console.WriteLine("\nRECORD ELIMINATI CORRETTAMENTE!");
                        Thread.Sleep(4000);
                        deleteFiles();

                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("\n\n" + exc.Message);
                        Thread.Sleep(4000);
                        return;
                    }
                }
            }
        }

        private static void deleteTable()
        {
            if (connectionString != null)
            {
                OleDbConnection con = new OleDbConnection(connectionString);
                using (con)
                {
                    con.Open();

                    OleDbCommand com = new OleDbCommand("DROP TABLE Veicoli", con);

                    try
                    {
                        com.ExecuteNonQuery();
                        Console.WriteLine("\nTABELLA ELIMINATA CORRETTAMENTE!");
                        Thread.Sleep(4000);
                        deleteFiles();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("\n\n" + exc.Message);
                        Thread.Sleep(4000);
                        return;
                    }
                }
            }
        }

        private static void deleteFiles()
        {
            DirectoryInfo dir = new DirectoryInfo($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\WindowsFormsAppProject\\bin\\Debug\\img");

            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Name != "NoImage.jpg")
                {
                    file.Delete();
                }
            }
            Console.WriteLine("\nFILES ELIMINATI CORRETTAMENTE!");
            Thread.Sleep(4000);
        }
        #endregion
    }
}