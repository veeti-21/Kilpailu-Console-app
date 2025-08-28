using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationInput
{
    internal class Program
    {
        public static string InformationInput()
        {
            string name;
            string sport;
            string points;
            
            Console.WriteLine("Please input your name:");
            name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please input your sport:");
            sport = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please input your points:");
            points = Console.ReadLine();

            return $"{name} {sport} {points}";
        }
    }
}