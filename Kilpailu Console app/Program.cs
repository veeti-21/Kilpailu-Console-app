static void yläpalkki(int maxLength, List<int> laji_lenghts) 
{
    Console.Write('+');
    for (int i = 0; i <= maxLength - 1; i++)
    {
        Console.Write("-");
    }
    Console.Write('+');
    foreach (int laji_lenght in laji_lenghts)
    {
        for (int lenght = 0; lenght <= laji_lenght - 1; lenght++)
        {
            Console.Write("-");
        }
        Console.Write('+');
    }
    for (int i = 0; i <= 15; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine('+');
    
}
static void ylänimet(int maxLength, List<string> lajit) {
    Console.Write('|');
    for (int i = 0; i <= maxLength - 5; i++)
    {

        if (i == maxLength / 2 - 3)
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
static void user(List<string> nimet, List<double> pisteet) {
    foreach (string nimi in nimet)
    {
        Console.Write("| ");
        Console.Write(nimi);
        Console.Write(" |");
        int x = nimet.IndexOf(nimi);
        

    }
}

List<string> lajit = new List<string>() { "jalkapallo","pesäpallo"};
List<string> nimet = new List<string>() { "jaamo pesälä", "veeti korpela","teimo jalkanen"};
List<double> pisteet = new List<double>() { 2,3,4,5,9,1};

int maxLength = nimet.Max(s => s.Length);
List<int> laji_lenghts = new List<int>();
foreach (string s in lajit)
{
    int x = s.Length;
    laji_lenghts.Add(x);
}

yläpalkki(maxLength, laji_lenghts);
ylänimet(maxLength, lajit);
yläpalkki(maxLength, laji_lenghts);
user(nimet,pisteet);





