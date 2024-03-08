// StreamReader sr = File.OpenText("deneme.txt");

// var s = "";

// while((s=sr.ReadLine())!=null){
//     System.Console.WriteLine(s);
// }

// string sonuc = File.ReadAllText("deneme.txt");
// System.Console.WriteLine(sonuc);



string[] sonuc = File.ReadAllLines("deneme.txt");

System.Console.WriteLine(sonuc[0]);
System.Console.WriteLine(sonuc[2]);
System.Console.WriteLine(sonuc[1]);