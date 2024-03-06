// Karşılaştırma operatör uygulamaları

// klavyeden girilen yaş bilgisine göre oy kullanabilme durumu inceleyiniz.

// Console.Write("yaşınız:");
// var yas = Convert.ToInt32(Console.ReadLine());
// var  sonuc  = (yas >=18 ) ? "ehliyet alabilirsiniz":"ehliyet için yaşınız tutmuyor.";
// Console.WriteLine(sonuc);


// Girilen bir sayının işaretini kontrol ediniz

// Console.Write("sayı: ");
// var sayi = Convert.ToInt32(Console.ReadLine());
// var sonuc = (sayi<0) ? "sayı negatiftir":"sayı pozitiftir.";
// Console.WriteLine(sonuc);


// Girilen sayının tek veya çift olma durumunu kontol edelim

Console.Write("sayı : ");
var sayi = Convert.ToInt32(Console.ReadLine());
var sonuc = (sayi%2==0)?"Sayı çifttir.": "sayı tektir";
Console.WriteLine(sonuc);