StreamReader sr = File.OpenText("deneme.txt");

var s = "";

while((s=sr.ReadLine())!=null){
    System.Console.WriteLine(s);
}