// if else uygulamaları

//1- kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız.


Console.Write("1. Sayı: ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayı: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Toplama için +");
Console.WriteLine("Çıkarma için -");
Console.WriteLine("Çarpma için *");
Console.WriteLine("Bölme için /");

Console.Write("Seçiminiz: ");
var secim = Console.ReadLine();


if (secim =="+")
{
    Console.WriteLine($"işlem sonucu: {sayi1} + {sayi2} = {sayi1+sayi2}");
}
else if(secim=="-"){
    Console.WriteLine($"işlem sonucu: {sayi1} - {sayi2} = {sayi1-sayi2}");
}
else if (secim == "*")
{
    Console.WriteLine($"işlem sonucu: {sayi1} * {sayi2} = {sayi1*sayi2}");
}
else if (secim=="/")
{
    if (sayi2==0)
    {
        Console.WriteLine("Bölen 0 olamaz");
    }else{
    Console.WriteLine($"işlem sonucu: {sayi1} / {sayi2} = {sayi1/sayi2}");
    }
}
else
{
    Console.WriteLine("yanlış secim");
}
