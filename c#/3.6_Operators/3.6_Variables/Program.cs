// Mantıksal operatör uygulamaları

// 1- Yaşı 18'den büyük ya da veli izni alan varsa bir işte çalışabilir durumu kontrol ediniz.

// int yas = 17;
// bool veli_izni = false;
// var sonuc = (yas>=18 || veli_izni)? "çalışabilir":"çalışamaz";
// Console.WriteLine(sonuc);

// 2- Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırınız.

// int not = 40;
// var sonuc = (not < 100 && not > 50) ? "geçti" : "kaldı";
// Console.WriteLine(sonuc);

// 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.

// var ortalama = 70;
// var zayif = 1;
// var sonuc = ortalama >= 70
//     ? zayif == 0 ? "teşekkür alabilir" : "zayıfınızın olmaması gerekiyor"
//     : "ortalamanızın en az 70 olması gerekiyor.";
// Console.WriteLine(sonuc);

// 4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.

// bool lisans = true;
// bool onlisans = false;
// bool sigaraIciyor = false;
// string sonuc = (sigaraIciyor == false)
//     ? ((onlisans || lisans) ? "işe alındınız!" : "bir lisans veya önlisans ınızın olması gerekiyor.")
//     : "sigara içmemeniz gerekiyor.";
// Console.WriteLine(sonuc);

// 5- uygulamaya giriş kontrolünü username ya da parola için yapalım.

string email = "berkayocer2003@gmail.com";
string username = "berkayocer";
string pass = "1234";

var sonuc = ((email == "berkayocer2003@gmail.com" || username == "berkayocer") && pass == "1234")
    ? "Giriş Yapıldı"
    : "lütfen bilgilerinizi kontrol ediniz.";

Console.WriteLine(sonuc);
