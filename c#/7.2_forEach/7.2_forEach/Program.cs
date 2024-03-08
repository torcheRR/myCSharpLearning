// forEach

string ad = "berkay";

for (int i = 0; i < ad.Length; i++)
{
    Console.WriteLine(ad[i]);
}

Console.WriteLine("---------------------------------------------");

foreach (var VARIABLE in ad)
{
    Console.WriteLine(VARIABLE);
}

Console.WriteLine("---------------------------------------------");

int[] sayilar = {1,2,3,4,5};

foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}