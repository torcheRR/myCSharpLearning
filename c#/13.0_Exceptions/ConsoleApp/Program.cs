namespace ConsoleApp{

    class Program{

        static void Main(string[] args){

            //Exception
            //System.FormatException
            //System.DivideByZeroException

            System.Console.Write("1. Sayı :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("2. Sayı :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            var sonuc = sayi1/sayi2;

            Urun urun= new Urun();
            System.Console.WriteLine(urun.urunAdi);



            //Exception Handling
        }
    }


    class Urun{

        public string urunAdi { get; set;}

    }
}