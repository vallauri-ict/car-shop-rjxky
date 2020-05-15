#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

using Newtonsoft.Json;
using System.Data.OleDb;
using System.Diagnostics;
using System.Threading;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using OpenXmlUtilities;
#endregion

namespace VenditaVeicoliDllProject
{
    [Serializable]
    public class SerializableBindingList<T> : BindingList<T>
    {

    }

    public class Utils
    {
        #region Word
        public static void createWordDoc()
        {
            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.accdb";
            string connStr = "Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + path;

            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    OleDbCommand com = new OleDbCommand("SELECT * FROM VEICOLI", con);
                    con.Open();

                    OleDbDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        string filepath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\.data\\Veicoli.docx";
                        WordprocessingDocument doc = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document);

                        MainDocumentPart mainPart = doc.AddMainDocumentPart();

                        mainPart.Document = new Document();
                        Body body = mainPart.Document.AppendChild(new Body());

                        ClsWord.AddStyle(mainPart, "Intestazione", "style1", "Consolas", 28, "#FF8800", true, false, false);

                        Paragraph headingPar = ClsWord.CreateParagraphWithStyle("Intestazione", JustificationValues.Center);
                        ClsWord.AddTextToParagraph(headingPar, "Vendita veicoli");
                        body.AppendChild(headingPar);

                        while (reader.Read())
                        {
                            string usato = String.Empty;
                            string kmzero = String.Empty;
                            if (reader.GetBoolean(8))
                            {
                                usato = "Sì";
                            }
                            else
                            {
                                usato = "No";
                            }
                            if (reader.GetBoolean(9))
                            {
                                kmzero = "Sì";
                            }
                            else
                            {
                                kmzero = "No";
                            }
                            if (reader.GetString(1) == "MOTO")
                            {
                                Paragraph p = body.AppendChild(new Paragraph());
                                Run r = p.AppendChild(new Run());
                                r.AppendChild(new Text("- " + reader.GetString(1)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Marca: " + reader.GetString(2)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Modello: " + reader.GetString(3)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Colore: " + reader.GetString(4)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Cilindrata: " + reader.GetInt32(5).ToString()));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("PotenzaKw: " + reader.GetInt32(6).ToString()));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Data di immatricolazione: " + reader.GetDateTime(7).ToShortDateString()));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Usato: " + usato));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Kmzero: " + kmzero));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Km percorsi: " + reader.GetInt32(10).ToString() + " km"));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Sella: " + reader.GetString(11)));
                                r.AppendChild(new Break());
                            }
                            else
                            {
                                Paragraph p = body.AppendChild(new Paragraph());
                                Run r = p.AppendChild(new Run());
                                r.AppendChild(new Text("- " + reader.GetString(1)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Marca: " + reader.GetString(2)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Modello: " + reader.GetString(3)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Colore: " + reader.GetString(4)));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Cilindrata: " + reader.GetInt32(5).ToString()));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("PotenzaKw: " + reader.GetInt32(6).ToString()));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Data di immatricolazione: " + reader.GetDateTime(7).ToShortDateString()));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Usato: " + usato));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Kmzero: " + kmzero));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Km percorsi: " + reader.GetInt32(10).ToString() + " km"));
                                r.AppendChild(new Break());
                                r.AppendChild(new Text("Numero di airbag: " + reader.GetString(11)));
                                r.AppendChild(new Break());
                            }
                        }
                        doc.Close();
                        Console.Write("\nDocumento creato. Vuoi aprirlo?[S/N]: ");
                        if (Console.ReadLine() == "S")
                        {
                            Process.Start(filepath);
                        }
                        else
                        {
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La tabella non contiene nessuna riga!");
                    }
                }
            }
        }
        #endregion

        #region CSV
        public static IEnumerable<string> ToCsv<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }

        public static string ToCsvString<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            StringBuilder csvdata = new StringBuilder();
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                csvdata.AppendLine(string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray()));
            }
            return csvdata.ToString();
        }
        #endregion

        #region Serialize
        public static void SerializeToCsv<T>(IEnumerable<T> objectlist, string pathName, string separator = "|")
        {
            IEnumerable<string> dataToSave = Utils.ToCsv(objectlist, separator);
            File.WriteAllLines(pathName, dataToSave);
        }

        public static void SerializeToXml<T>(SerializableBindingList<T> objectlist, string pathName)
        {
            XmlSerializer x = new XmlSerializer(typeof(SerializableBindingList<T>));
            TextWriter writer = new StreamWriter(pathName);
            x.Serialize(writer, objectlist);
        }

        public static void SerializeToJson<T>(IEnumerable<T> objectlist, string pathName)
        {
            string json = JsonConvert.SerializeObject(objectlist, Formatting.Indented);
            File.WriteAllText(pathName, json);
        }
        #endregion
    }
}