using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zeugnisse
{
    internal class Program
    {
        static void Main(string[] args)

        {
            {
                {
                    Boolean Abfrage = false;
                    string filePath = @"C:\Users\Vincent Admin\Desktop\WriteFile.txt";
                    StreamWriter writer = new StreamWriter(filePath);
                    int Ergebnis;
                    int EntschuldigtTage, UnentschuldigtTage;
                    double Durchschnitt;
                    int Unterkurse;
                    int Deutsch, Mathe, Physik, English, Erdkunde, Sport, Chemie, Informatik;
                   // string name;
                    //Eingabe

                  Regex namePattern = new Regex ("^[A-Z a-z]+$");
                  Regex datePattern = new Regex (@"^(3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})$");


                    string Sname;
                    do    
                    {
                        Console.WriteLine("Geben Sie den Namen des Schülers ein: ");
                        Sname = Console.ReadLine();
                        if(Sname.Length > 20)
                        {
                            Console.WriteLine("Name ist zu lang!");
                            Console.WriteLine("Gib einen neuen NAmen ein:");
                            Sname = Console.ReadLine();
   

                        }
                      

                        if (!namePattern.IsMatch(Sname))
                        {
                            Console.WriteLine("Ungültige des Namensformats");
                        }
                    } while (!namePattern.IsMatch(Sname));
                   // if 

                    string datumInput;
                    do
                    {
                        Console.WriteLine("Geben Sie das Ausstellungsdatum ein (Leer lassen, für heutiges Datum): ");
                        datumInput = Console.ReadLine();
                        if (string.IsNullOrEmpty(datumInput)) 
                        {
                            datumInput = DateTime.Now.ToString("dd.MM.yyyy");
                        }

                        if (!datePattern.IsMatch(datumInput)) 
                        {
                            Console.WriteLine("Sie müssen ein korrektes Datumsformat tt.mm.jjjj angeben!");
                        }
                    } while (!datePattern.IsMatch(datumInput));




                    Console.WriteLine("Es ist wichtig, dass alle Noten in Punkten angegeben werden, von 0-15!");
                    Console.WriteLine("Entschuldigte Fehltage: ");
                    EntschuldigtTage = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Unentschuldigte Fehltage: ");
                    UnentschuldigtTage = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gib die Note für Deutsch LK ein:");
                    Deutsch = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Gib die Note für Mathe LK ein:");
                    Mathe = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gib die Note für Physik ein:");
                    Physik = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gib die Note für English ein:");
                    English = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gib die Note für Erdkunde ein:");
                    Erdkunde = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gib die Note für Sport ein:");
                    Sport = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gib die Note für Chemie ein:");
                    Chemie = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gib die Note für Informatik ein:");
                    Informatik = Convert.ToInt32(Console.ReadLine());


                    // Überprüfung der Eingabe der Noten

                    if (Deutsch > 15 || Mathe > 15 || Physik > 15 || English > 15 || Erdkunde > 15 || Sport > 15 || Chemie > 15 || Informatik > 15)
                    {
                        Console.WriteLine("Stop!. Noteneingabe ist nicht richtig.");
                        Console.ReadKey(true);
                        return;
                    }


                    //Berechnung + Gewichtung	
                    Mathe *= 2;
                    Deutsch *= 2;

                    Ergebnis = Deutsch + Mathe + Physik + Chemie + Sport + Informatik + English + Erdkunde;

                    Durchschnitt = Ergebnis / 10;
                    Durchschnitt = Convert.ToDouble(Durchschnitt);
                    Math.Round(Durchschnitt, 1);


                    // Ausgabe des Zeugnisses
                    Console.WriteLine("=== Zeugnis ===");
                    Console.WriteLine("Schüler: " + Sname);
                   Console.WriteLine("Ausstellungsdatum: " + datumInput);
                    Console.WriteLine("========================");
                    Console.WriteLine("Entschuldigte Fehltage: " + EntschuldigtTage);
                    Console.WriteLine("Unentschuldigte Fehltage: " + UnentschuldigtTage);
                    Console.WriteLine("========================");
                    Console.WriteLine("Noten:");
                    Console.WriteLine("");
                    Console.WriteLine("Naturwissenschaften: ");
                    Console.WriteLine("");
                    Console.WriteLine("Chemie: " + Chemie);
                    Console.WriteLine("Informatik: " + Informatik);
                    Console.WriteLine("Mathe: " + Mathe/2);
                    Console.WriteLine("Physik: " + Physik);
                    Console.WriteLine("");
                    Console.WriteLine("Sprachen:");
                    Console.WriteLine("");
                    Console.WriteLine("Deutsch: " + Deutsch / 2);
                    Console.WriteLine("English: " + English);
                    Console.WriteLine("");
                    Console.WriteLine("Gesellschaftswissenschaften: ");
                    Console.WriteLine("");
                    Console.WriteLine("Erdkunde: " + Erdkunde);
                    Console.WriteLine("");
                    Console.WriteLine("Sport: " + Sport);
                    Console.WriteLine("===========================");
                    Console.WriteLine("Notendurchschnitt: " + Durchschnitt);





                    // Entscheidung über Versetzung
                    if (Durchschnitt >= 5)
                    {
                        if (UnentschuldigtTage > 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Der Schüler wird nicht versetzt! Die unentschuldigten Fehltage sind zu hoch");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Der Schüler wird versetzt!");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Der Schüler wird nicht versetzt! Der Durchschnitt ist zu niedrig");
                    }

                    Console.ResetColor();
                    

                    

                    writer.WriteLine("=== Zeugnis ===");
                    writer.WriteLine("Schüler: " + Sname);
                    writer.WriteLine("Ausstellungsdatum: " + datumInput);
                    writer.WriteLine("========================");
                    writer.WriteLine("Entschuldigte Fehltage: " + EntschuldigtTage);
                    writer.WriteLine("Unentschuldigte Fehltage: " + UnentschuldigtTage);
                    writer.WriteLine("========================");
                    writer.WriteLine("Noten:");
                    writer.WriteLine("");
                    writer.WriteLine("Naturwissenschaften: ");
                    writer.WriteLine("");
                    writer.WriteLine("Chemie: " + Chemie);
                    writer.WriteLine("Informatik: " + Informatik);
                    writer.WriteLine("Mathe: " + Mathe / 2);
                    writer.WriteLine("Physik: " + Physik);
                    writer.WriteLine("");
                    writer.WriteLine("Sprachen:");
                    writer.WriteLine("");
                    writer.WriteLine("Deutsch: " + Deutsch / 2);
                    writer.WriteLine("English: " + English);
                    writer.WriteLine("");
                    writer.WriteLine("Gesellschaftswissenschaften: ");
                    writer.WriteLine("");
                    writer.WriteLine("Erdkunde: " + Erdkunde);
                    writer.WriteLine("");
                    writer.WriteLine("Sport: " + Sport);
                    writer.WriteLine("===========================");
                    writer.WriteLine("Notendurchschnitt: " + Durchschnitt);
                    Console.WriteLine("Datei wurde gespeichert");
                    writer.Close();
                    StreamReader Sr = new StreamReader(filePath);
                    Console.WriteLine(Sr);

                    Console.ReadKey();
                }








        }
    }
}
}
