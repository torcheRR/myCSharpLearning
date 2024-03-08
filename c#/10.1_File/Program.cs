// File

// StreamWriter sw = File.CreateText("deneme.txt");

// sw.WriteLine("BTK");
// sw.WriteLine("Berkay");

// sw.Close();



// using(StreamWriter sw = File.CreateText("deneme.txt")){
//     sw.WriteLine("BTK");
//     sw.WriteLine("Berkay");
//     sw.WriteLine("Yaren");
//     sw.Close();
// }

// using(StreamWriter sw = File.AppendText("deneme.txt")){
//     sw.WriteLine("Beykent");
//     sw.WriteLine("Berkay");
//     sw.WriteLine("Yaren");
//     sw.Close();
// }


File.WriteAllText("deneme.txt","merhaba");
File.AppendAllText("deneme.txt",", selam");


using(StreamReader sr = File.OpenText("deneme.txt")){
    var s ="";

    while((s=sr.ReadLine())!=null){
        System.Console.WriteLine(s);
    }
}