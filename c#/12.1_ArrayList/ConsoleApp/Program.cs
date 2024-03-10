using System.Collections;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList

            //non generic =>object
            //dinamik

            ArrayList liste = new ArrayList();

            liste.Add(10);
            liste.Add("10");
            liste.Add("berkay");
            liste.Add(null);
            liste.Add(true);

            var liste2 = new ArrayList(){
                    5,
                    "berkay",
                    false,
                    4.5,
                    null
                };

            int[] sayilar = { 10, 20, 30 };

            liste.AddRange(sayilar);

            var eleman = (int)liste[0];
            var isim = liste[2].ToString();

            // System.Console.WriteLine(isim);


            //instert
            liste.Insert(1, "yaren");
            liste.InsertRange(5, liste2);


            //remove
            liste.Remove(null);
            liste.RemoveAt(6);
            liste.RemoveRange(5, 3);



            //contains, indexof
            System.Console.WriteLine(liste.Contains("yaren"));
            System.Console.WriteLine(liste.IndexOf("berkay"));


            //             foreach (var item in liste)
            // {
            //     System.Console.WriteLine(item);
            // }




        }
    }
}
