// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboard
{
    internal class Program
    {
        public static List<string> lajit = new List<string>() { "jalkapallo", "pesäpallo" };
        public static List<string> nimet = new List<string>() { "jaamo pesälä", "veeti korpela", "teimo jalkanen" };
        public static List<double> pisteet = new List<double>() { 2, 3, 4, 5, 9, 1 };

        static void Main()
        {
            InformationInput.Program.InformationInput();

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