namespace ConsoleApp{
    class Program{
        static void Main(string[] args){
                System.Console.WriteLine(HelperMethods.karakterDuzelt("ölçme ve değerlendirme"));

        }

        class HelperMethods{
            public static string karakterDuzelt(string str){
                return 
                str.Replace("ü","u")
                .Replace("ı","i")
                .Replace("ö","o")
                .Replace("ğ","g")
                .Replace("ç","c")
                .Replace(" ","-");
            }
        }
    }
}