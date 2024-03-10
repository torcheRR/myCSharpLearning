namespace ConsoleApp{

    class Program{

        static void Main(string[] args){

            //dictionary

            //key-value==> plaka - şehir

            Dictionary<int,string> plakalar = new Dictionary<int, string>();

            plakalar.Add(58,"Sivas");
            plakalar.Add(34,"İstanbul");
            plakalar.Add(28,"Giresun");


            Dictionary<int,string> sayilar = new Dictionary<int, string>(){
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"}
            };

            // System.Console.WriteLine(plakalar[28]);

            if(plakalar.ContainsKey(61)){
                System.Console.WriteLine(plakalar[61]);
            }


            foreach(var plaka in plakalar){
                System.Console.WriteLine(plaka.Key + " " + plaka.Value);
            }


            //update 
            sayilar[1] = "one";
            // sayilar.Remove(1);
            //sayilar.Clear();

            System.Console.WriteLine(sayilar[1]);

        }
    }
}