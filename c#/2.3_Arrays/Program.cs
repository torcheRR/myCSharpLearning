/*

Dizi Uygulama

    ogrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3. öğrenci)

    ogrenciler dizisi kaç elemanlıdır, yazdırınız.
    ilk 2 ogrencinin ad ve not bilgisini yazdırınız.
    tüm ogrencilerin not ortalaması nedir?

*/

var ogrenciler = new string[2];
var notlar = new int[2];

System.Console.Write("1. öğrenci adı: ");
ogrenciler[0]= Console.ReadLine() ?? "";        // null olma durumunda boş karakter ataması sağlar.


System.Console.Write("1. öğrenci notu: ");
notlar[0]= Convert.ToInt32(Console.ReadLine()); 


System.Console.Write("2. öğrenci adı: ");
ogrenciler[1]= Console.ReadLine() ?? "";        


System.Console.Write("2. öğrenci notu: ");
notlar[1]= Convert.ToInt32(Console.ReadLine()); 

foreach(var ogrenci in ogrenciler){
    System.Console.WriteLine(ogrenci);
}

foreach ( var not in notlar){
    System.Console.WriteLine(not);
}


System.Console.WriteLine("Öğrenciler dizisinin eleman sayısı: " + ogrenciler.Length);

var ortalama = (notlar[0]+notlar[1])/2;

System.Console.WriteLine("Bu notların ortalaması : "+ ortalama);