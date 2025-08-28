

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {

        public static void Main()
        {
            string answer;
            bool validAnswer = false;

            Console.WriteLine("Haluatko katsoa vai lisätä tuloksia?\n1. Katso\n2. Lisää");
            answer = Console.ReadLine();

            do
            {
                switch (answer)
                {
                    case "1":
                        validAnswer = true;
                        Console.Clear();
                        gui.gui.gui_start();
                        break;
                    case "2":
                        validAnswer = true;
                        Console.Clear();                       
                        break;
                    default:
                        validAnswer = false;
                        Console.Clear();
                        break;
                }
            } while (!validAnswer);
        }
    }
}

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

