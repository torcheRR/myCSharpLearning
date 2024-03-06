/*

    Uygulama 1: Bir öğrencinin aşağıdaki bilgileri için gerekli değişkenenleri oluşturunuz.
    
    Öğrenci adı
    Öğrenci soyadı
    Öğrenci ad ve soyad
    öğrenci numarası
    öğrenci cinsiyeti
    öğrenci tc kimlik
    öğrenci doğum yılı
    öğrenci adres bilgisi
    öğrenci yaşı
    
    
    Uygulama 2: Aşağıdaki ürünlerin toplam bilgisini hesaplayınız.
    
    Ürün 1 => 50 TL
    Ürün 2 => 60.5 Tl
    Ürün 3 => 356.45 TL
*/


using System.Security.Cryptography;

Console.WriteLine("Uygulama 1:");

string ad = "Berkay";
string soyad = "ÖCER";
string adSoyad = ad + " " + soyad;
int ogrenciNum = 2103013260;
string cinsiyet = "Male";
long tc = 11111111111;
DateTime dg = new DateTime(2003,11,14);
string adres = "Istanbul/Kagithane";
double yas = (double.Parse(DateTime.Now.Year.ToString())-double.Parse(dg.Year.ToString()));

Console.WriteLine("Name : " + ad);
Console.WriteLine("Surname : " + soyad);
Console.WriteLine("Fullname : " + adSoyad);
Console.WriteLine("Student Number : " + ogrenciNum);
Console.WriteLine("Sex : " + cinsiyet);
Console.WriteLine("ID : " + tc);
Console.WriteLine("Age : "+yas);
Console.WriteLine("Adress : " + adres);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Uyguluma 2:");

double urun1 = 50;
double urun2 = 60.5;
double urun3 = 356.45;
double toplam = urun3 + urun2 + urun1;

Console.WriteLine("   Ürün 1 => "+urun1+"     TL");
Console.WriteLine("   Ürün 2 => "+urun2+"   TL");
Console.WriteLine("   Ürün 4 => "+urun3+" TL");
Console.WriteLine("+");
Console.WriteLine("---------------------------");
Console.WriteLine("   Total  => "+ toplam+" TL");

