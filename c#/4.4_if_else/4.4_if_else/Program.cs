// if else uygulamaları

//3- girilen 3 sayıdan en büyüğünü bulunuz

Console.Write("1. Sayı: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayı: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. Sayı: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2 && num1>num3)
{
    Console.WriteLine($"en büyük sayı {num1}'dir.");
}
if (num2>num1 && num2>num3)
{
    Console.WriteLine($"en büyük sayı {num2}'dir.");
}
if (num3>num2 && num3>num1)
{
    Console.WriteLine($"en büyük sayı {num3}'dir.");
}