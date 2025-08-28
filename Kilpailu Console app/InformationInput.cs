using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationInput
{
    internal class Methods
    {
        public static void InformationInput()
        {
            string name;
            string sport;
            double points;

            Console.WriteLine("Anna nimesi:");
            name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Anna lajisi:");
            sport = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Anna pisteesi:");
            double.TryParse(Console.ReadLine(), out points);

            gui.gui.nimet.Add(name);
            gui.gui.lajit.Add(sport);
            gui.gui.pisteet.Add(points);

            Console.Clear();

            Program.Program.Main();
        }
    }
}