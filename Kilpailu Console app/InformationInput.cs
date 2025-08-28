using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationInput
{
    internal class Program
    {
        public static void InformationInput()
        {
            string name;
            string sport;
            double points;

            Console.WriteLine("Please input your name:");
            name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please input your sport:");
            sport = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please input your points:");
            double.TryParse(Console.ReadLine(), out points);

            Scoreboard.Program.nimet.Add(name);
            Scoreboard.Program.lajit.Add(sport);
            Scoreboard.Program.pisteet.Add(points);
        }
    }
}