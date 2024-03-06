/*
    Strings: Karakter dizileri.
*/

Console.Write("adı: ");
var ad = Console.ReadLine();

Console.Write("soyad: ");
var soyad = Console.ReadLine();

Console.Write("yaş: ");
var yas = Console.ReadLine();


//string mesaj = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır.";

string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır";
Console.WriteLine(mesaj);