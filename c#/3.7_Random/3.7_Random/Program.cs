// Random

Random rnd = new Random();

string[] takimlar = { "Beşiktaş", "Galatasaray", "Fenerbahçe", "TrabzonSpor" };

int sayi = rnd.Next(10,20);

Console.WriteLine(sayi);

Console.WriteLine(takimlar[rnd.Next(takimlar.Length)]);