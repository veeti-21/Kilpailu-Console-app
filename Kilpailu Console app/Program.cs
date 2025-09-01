// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Scoreboard
{
    internal class Program
    {
        public static List<string> lajit = new List<string>() { "jalkapallo", "pesäpallo" };
        public static List<string> nimet = new List<string>() { "jaamo pesälä", "veeti korpela", "teimo jalkanen" };
        public static List<double> pisteet = new List<double>() { 2, 3, 4, 5, 9, 1 };

        public static string filePath = "Tulokset.txt";
        static void Main()
        {
            InformationInput.Program.InformationInput();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("---- Uusi tallennus ----");


                for (int i = 0; i < nimet.Count; i++)
                {
                    string nimi = nimet[i];
                    string laji = (i < lajit.Count) ? lajit[i] : "tuntematon";
                    double piste = (i < pisteet.Count) ? pisteet[i] : 0;

                    writer.WriteLine($"Nimi: {nimi}, Laji: {laji}, Pisteet: {piste}");
                }

                writer.WriteLine(); // Tyhjä rivi loppuun
            }

            foreach (string nimi in nimet)
            {
                Console.Write($"{nimi}, ");
            }

            foreach (string laji in lajit)
            {
                Console.Write($"{laji}, ");
            }

            foreach (double piste in pisteet)
            {
                Console.Write($"{piste}, ");
            }
        }
    }
}