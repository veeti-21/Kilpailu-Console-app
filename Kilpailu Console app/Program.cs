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

            do
            {
                Console.WriteLine("Haluatko katsoa vai lisätä tuloksia?\n1. Katso\n2. Lisää");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        validAnswer = true;
                        Console.Clear();
                        gui.gui.gui_start();

                        //CheckFunctionality();

                        break;
                    case "2":
                        validAnswer = true;
                        Console.Clear();
                        InformationInput.Methods.InformationInput();
                        break;
                    default:
                        validAnswer = false;
                        Console.Clear();
                        break;
                }
            } while (!validAnswer);

            static void CheckInfoInputFunctionality()
            {
                foreach (string name in gui.gui.nimet)
                {
                    Console.WriteLine($"| Name: {name} |");
                }

                foreach (string sport in gui.gui.lajit)
                {
                    Console.WriteLine($"| Sport: {sport} |");
                }

                foreach (double point in gui.gui.pisteet)
                {
                    Console.WriteLine($"| Point: {point} |");
                }

                Console.ReadKey();

                Console.Clear();

                Main();
            }
        }
    }
}