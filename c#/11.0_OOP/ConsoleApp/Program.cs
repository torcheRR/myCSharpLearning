using System;
using System.IO;

namespace ConsoleApp{
    class Program
    {
        static void Main(string[] args){

            //class => object (ogr1, ogr2)

            Ogrenci ogr1 = new Ogrenci(){   AdSoyad = "Berkay Öcer",  Sube = "102",   OgrenciNo = "2103013260"    };
            Ogrenci ogr2 = new Ogrenci(){   AdSoyad = "Yaren Öcer",  Sube = "102",   OgrenciNo = "2103013225"    };
            Ogrenci ogr3 = new Ogrenci(){   AdSoyad = "Gökay Öcer",  Sube = "5/B",   OgrenciNo = "123"    };

            Ogrenci[] ogrenciler = new Ogrenci[3]{ogr1,ogr2,ogr3};

            foreach (var ogrenci in ogrenciler){
                System.Console.WriteLine(ogrenci.BilgileriYazdır());
            }

        }
    }

    class Ogrenci{
        //peoperty => string, int
        
        public string OgrenciNo { get; set; }
        public string AdSoyad { get; set; }
        public string Sube { get; set; }

        //methods

        // public void BilgileriYazdır(){
        //     System.Console.WriteLine($"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}");
        // }

        public string BilgileriYazdır(){
            return $"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}";
        }


    }
}

//ConsoleApp => Program, Ogrenci
//System => Console
//System.IO => File, Directort, Path