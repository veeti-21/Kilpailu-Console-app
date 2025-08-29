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
            bool sportExists;

            Console.WriteLine("Anna nimesi:");
            name = Console.ReadLine();

            gui.gui.nimet.Add(name);

            Console.Clear();

            Console.WriteLine("Anna lajisi:");
            sport = Console.ReadLine();

            sportExists = gui.gui.lajit.Contains(sport.ToLower()) || gui.gui.lajit.Contains(sport);

            if (!sportExists)
            {
                gui.gui.lajit.Add(sport);
            }

            Console.Clear();

            foreach (string laji in gui.gui.lajit)
            {
                Console.WriteLine($"Anna pisteesi {laji}ssa:");
                double.TryParse(Console.ReadLine(), out points);

                if (points != null)
                {
                    gui.gui.pisteet.Add(points);
                }

                Console.Clear();
            }

            Program.Program.Main();
        }
    }
}