/*
 * Created by SharpDevelop.
 * User: Teoman
 * Date: 22.05.2024
 * Time: 09:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Console_application
{
	class Program
	{
		public static void Main(string[] args)
		{
			int Ergebnis;
			int Durchschnitt;
			
			//while (true)
			{	
			Console.WriteLine("Geben Sie den Namen des Schülers ein:");
			
			string schuelerName = Console.ReadLine();	
			
		 	if (schuelerName.Contains("1234567890!§$%&/()=?+-,.-°"));
			  {  
			   Console.WriteLine("Der Name ist ungültig");
				
				}
			}    
			
				
			
			Console.Write("Geb das Datum ein (dd.MM.yyyy): ");
			
			string DatumInput = Console.ReadLine();
			Console.WriteLine("Es ist wichtig, dass alle Noten in Punkten angegeben werden, von 0-15!");
			
			
			Console.WriteLine("Gib die Note für Deutsch LK ein:");
			int Deutsch;
			Deutsch = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Gib die Note für Mathe LK ein:");
			int Mathe;
			Mathe = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Gib die Note für Physik ein:");
			int Physik;
			Physik = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Gib die Note für English ein:");
			int English;
			English = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Gib die Note für Erdkunde ein:");
			int Erdkunde;
			Erdkunde = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Gib die Note für Sport ein:");
			int Sport;
			Sport = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Gib die Note für Chemie ein:");
			int Chemie;
			Chemie = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Gib die Note für Informatik ein:");
			int Informatik;
			Informatik = Convert.ToInt32(Console.ReadLine());
			
				
			Mathe *= 2;
			Deutsch *= 2;
			
		//	Console.WriteLine(Deutsch);
			
			Ergebnis = Deutsch + Mathe + Physik + Chemie  + Sport + Informatik + English + Erdkunde;
			
			Durchschnitt = Ergebnis / 10;
			
			Console.WriteLine("Dein Durchschnitt:");
			Console.WriteLine (Durchschnitt);
			
			
			Console.ReadKey();
			
			
			
			
			
		}
	}
}