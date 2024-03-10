namespace ConsoleApp{

    class Program{

        static void Main(string[] args){

            //Exception
            //System.FormatException
            //System.DivideByZeroException
        try{
            System.Console.Write("1. Sayı :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("2. Sayı :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            var sonuc = sayi1/sayi2;

            System.Console.WriteLine(sonuc);
        }
        // catch(FormatException){
        //     System.Console.WriteLine("sayısal bilgileri düzgün giriniz.");
        // }catch(DivideByZeroException){
        //     System.Console.WriteLine("sayı sıfıra bölünemez");
        // }
        catch(Exception e){
            System.Console.WriteLine($"Hata :{e.Message}");
        }




            //Exception Handling
        }
    }
}