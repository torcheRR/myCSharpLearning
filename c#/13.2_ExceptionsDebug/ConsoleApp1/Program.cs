namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayi1=10;
            var sayi2 = 20;


            var sonuc = Toplam(sayi1,sayi2);

            System.Console.WriteLine(sonuc);
        }

        static int Toplam(int a , int b){
            return a+b;
        }
    }
}

