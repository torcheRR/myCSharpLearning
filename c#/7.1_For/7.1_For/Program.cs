// for uygulamları

//1- 1 den 100 e kadar olan sayıların toplamını yazdırınız
//
// int toplam =0;
// for (int i = 0; i <= 100; i++)
// {
//     toplam += i;
// }
//
// Console.WriteLine(toplam);

//2- Klavyeden girilen başlangıç ve bitiş değerleri arasındaki tüm sayıların toplamını hesaplayınız.
//
// Console.Write("Başlangıç: ");
// var baslagic = Convert.ToInt32(Console.ReadLine());
//
// Console.Write("Bitiş: ");
// var bitis = Convert.ToInt32(Console.ReadLine());
//
// int toplam = 0;
// for (int i = baslagic; i < bitis; i++)
// {
//     toplam += baslagic;
// }
//
// Console.WriteLine(toplam);

// 3- {"yaren","berkay","nilay","gökay","selenay"} dizisindeki tüm elemanları ekrana yazdır.

// string[] isimler = { "yaren", "berkay", "nilay", "gökay", "selenay" };
//
// for (int i = 0; i < isimler.Length; i++)
// {
//     Console.WriteLine(isimler[i]);
// }


// 4- {1,3,4,36,41,56,89} dizisindeki sayıların hangileri 3'ün katıdır?

/*
int[] sayilar = {1,3,4,36,41,56,89};

foreach (var sayi in sayilar)
{
    if (sayi%3==0)
    {
        Console.WriteLine(sayi);
    }
}

*/

int[] sayilar = {1,3,4,36,41,56,89};

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i]%3==0)
    {
        Console.WriteLine(sayilar[i]);
    }
}
