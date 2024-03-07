﻿// if else uygulmaları

//2- Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazınız.

// 0 - 24 => 0
// 25 - 44 => 1
// 45 - 54 => 2
// 55 - 69 => 3
// 70 - 84 => 4
// 85 - 100 => 5

Console.Write("1. Yazılı: ");
int not1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Yazılı: ");
int not2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Sözlü: ");
int sozlu = Convert.ToInt32(Console.ReadLine());

var ortalama = (not1 + not2 + sozlu) / 3;
int not = -1;

if (ortalama>=0 && ortalama<25)
{
    not = 0;
}
else if (ortalama>=25 && ortalama<45)
{
    not = 1;
}
else if (ortalama >= 45 && ortalama < 55)
{
    not = 2;
}
else if (ortalama >= 55 && ortalama < 70)
{
    not = 3;
}
else if (ortalama >= 70 && ortalama < 85)
{
    not = 4;
}
else if (ortalama >= 85 && ortalama <= 100 )
{
    not = 5;
}
else
{
    Console.WriteLine("yanlış not girdiniz.");
}

if (not!=-1)
{
    Console.WriteLine($"not ortalamanız: {ortalama} ve notunuz: {not}");
}