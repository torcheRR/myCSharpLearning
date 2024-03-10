namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[] { "Pyhton", "C#", "Java", "Html" }, "Html");
            var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[] { "Pyhton", "C#", "Java", "Html" }, "c#");
            var soru3 = new Soru(3, "Hangisi en popüler web programlama platformudur?", new string[] { "Pyhton", "ASP.Net", "Django", "Spring" }, "Python");

            System.Console.WriteLine(soru1.soruYazdir());
            System.Console.WriteLine(soru1.cevapKontrol(Console.ReadLine()));

            System.Console.WriteLine(soru2.soruYazdir());
            System.Console.WriteLine(soru2.cevapKontrol(Console.ReadLine()));

            System.Console.WriteLine(soru3.soruYazdir());
            System.Console.WriteLine(soru3.cevapKontrol(Console.ReadLine()));

        }

    }


        // protected, internal, protected internal, private protected
    class Soru
    {
        public Soru(int soruID, string soruMetni, string[] secenekler, string cevap)
        {
            this.soruID = soruID;
            this.soruMetni = soruMetni;
            this.secenekler = secenekler;
            this.cevap = cevap;
        }

        //properties
        private int soruID { get; set; }
        private string soruMetni { get; set; }
        private string[] secenekler { get; set; }
        private string cevap { get; set; }


        public string soruYazdir()
        {
            string soru = "\n";
            soru += this.soruMetni + "\n";

            foreach (var secenek in this.secenekler)
            {
                soru += secenek + "\n";
            }
            return soru;
        }

        //methods
        public bool cevapKontrol(string cevap)
        {
            return this.cevap.ToLower() == cevap.ToLower();
        }
    }
}