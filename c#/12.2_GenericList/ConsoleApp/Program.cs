namespace ConsoleApp{
    class Program{
        static void Main(string[] args){

            //Generic List

            List<int> sayilar = new List<int>();

            sayilar.Add(10);
            sayilar.Add(20);

            List<string> isimler = new List<string>{"berkay","yaren","niloş"};


            List<Product> urunler = new List<Product>();

            urunler.Add(new Product(){Id=1,title="iphone11",price=25000});
            urunler.Add(new Product(){Id=2,title="iphone12",price=35000});
            urunler.Add(new Product(){Id=3,title="iphone13",price=45000});

            urunler.Insert(urunler.Count,new Product(){Id=4,title="iphone14",price=55000});

            urunler.RemoveAt(2);

            urunler.Remove(urunler[0]);


            foreach(var urun in urunler){
                System.Console.WriteLine($"{urun.title} {urun.price}");
            }


        }
    }

    class Product
    {
        public int Id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
    }
}