/*
            String Uygululamaları
*/

string kursAdi = ".NET 7.0 ile C#cd Programlama Dili";


// 1- Kaç karaktere sahiptir?
// 2- Hepsini küçük harf yapınız.
// 3-'.' ile mi başlamaktadır?
// 4- C# bilgisi hangi konumda bulunmaktadır?
// 5- String 'C#' bilgisini içeriyor mu?
// 6- 'Dili' kelimesi yerine 'Dersleri' yazınız. (replace)


//1
var karakterSayisi = kursAdi.Length;
System.Console.WriteLine(karakterSayisi);

//2
var kucukHarf = kursAdi.ToLower();
Console.WriteLine(kucukHarf);

//3
Console.WriteLine(kursAdi.StartsWith('.'));

//4
Console.WriteLine(kursAdi.IndexOf("C#"));

//5
Console.WriteLine(kursAdi.Contains("C#"));

//6
Console.WriteLine(kursAdi.Replace("Dili","Dersleri"));