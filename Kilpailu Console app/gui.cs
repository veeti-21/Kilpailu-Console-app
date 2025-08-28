
using System.Security.Cryptography.X509Certificates;

namespace gui
{
    internal class gui
    {
        public static List<string> lajit = new List<string>() { "jalkapallo", "pesäpallo" };
        public static List<string> nimet = new List<string>() { "jaamo pesälä", "veeti korpela", "teimo jalkanen" };
        public static List<double> pisteet = new List<double>() { 2, 3, 4, 5, 9, 1 };

        static void yläpalkki(int nimi_max_pituus, List<int> laji_pituudet)
        {
            Console.Write('+');
            for (int viivat = 0; viivat <= nimi_max_pituus - 1; viivat++)
            {
                Console.Write("-");
            }
            Console.Write('+');
            foreach (int laji in laji_pituudet)
            {
                for (int pituus = 0; pituus <= laji - 1; pituus++)
                {
                    Console.Write("-");
                }
                Console.Write('+');
            }
            for (int viivat = 0; viivat <= 15; viivat++)
            {
                Console.Write("-");
            }
            Console.WriteLine('+');

        }
        static void ylänimet(int nimi_max_pituus, List<string> lajit)
        {
            Console.Write('|');
            for (int välit = 0; välit <= nimi_max_pituus - 5; välit++)
            {

                if (välit == nimi_max_pituus / 2 - 3)
                {
                    Console.Write("nimi");
                }
                Console.Write(" ");
            }
            Console.Write('|');
            foreach (string laji in lajit)
            {
                Console.Write($"{laji}|");
            }
            Console.WriteLine("pisteet yhteensä|");
        }
        static void user(List<string> nimet, List<double> pisteet, List<string> lajit, int nimi_max_pituus)
        {
            foreach (string nimi in nimet)
            {
                Console.Write("|");
                Console.Write(nimi);
                int nimimäärä = nimet.IndexOf(nimi);

                for (int välit = 0; välit <= nimi_max_pituus - 1 - nimi.Length; välit++)
                {
                    Console.Write(" ");
                }
                Console.Write('|');

                int pisteiden_summa = 0;

                foreach (string laji in lajit)
                {
                    for (int pituus = 0; pituus <= laji.Length - 2; pituus++)
                    {
                        Console.Write(" ");
                        if (pituus == laji.Length / 2 - 1)
                        {
                            Console.Write(pisteet[nimimäärä]);
                            nimimäärä += nimet.Count;
                            pisteiden_summa += nimimäärä;
                        }
                    }
                    Console.Write("|");
                }

                for (int i = 0; i <= 15 - pisteiden_summa.ToString().Length; i++)
                {
                    Console.Write(" ");
                    if (i == 6)
                    {
                        Console.Write(pisteiden_summa);
                    }

                }
                Console.WriteLine("|");


            }
        }

        public static void gui_start()
        {
            int nimi_max_pituus = nimet.Max(s => s.Length);
            List<int> laji_pituudet = new List<int>();

            foreach (string laji in lajit)
            {
                int pituus = laji.Length;
                laji_pituudet.Add(pituus);
            }

            yläpalkki(nimi_max_pituus, laji_pituudet);
            ylänimet(nimi_max_pituus, lajit);
            yläpalkki(nimi_max_pituus, laji_pituudet);
            user(nimet, pisteet, lajit, nimi_max_pituus);
            yläpalkki(nimi_max_pituus, laji_pituudet);

            Console.ReadKey();

            Console.Clear();

            Program.Program.Main();
        }
    }
}