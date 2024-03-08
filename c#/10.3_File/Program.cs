// File

//string path = @"C:\temp";
// string path = "/Users/berkayocer/Desktop/github/myCSharpLearning/c#/10.3_File/temp";

string rootPath = Directory.GetCurrentDirectory();

// string[] dirs = Directory.GetDirectories(rootPath , "*" , SearchOption.AllDirectories);

// foreach (var dir in dirs){
//         System.Console.WriteLine(dir);
// }


string soruce_path = "/Users/berkayocer/Desktop/github/myCSharpLearning/c#/10.3_File/img";
string dest_path = "/Users/berkayocer/Desktop/github/myCSharpLearning/c#/10.3_File/images/";

string[] files = Directory.GetFiles(soruce_path,"*",SearchOption.AllDirectories);

foreach(var file in files){
    System.Console.WriteLine(file);
    System.Console.WriteLine(Path.GetExtension(file));
    System.Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    System.Console.WriteLine(Path.GetFileName(file));

    var info = new FileInfo(file);

    System.Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");


    if(!Directory.Exists(dest_path)){
            Directory.CreateDirectory(dest_path);
    }

    string name =Path.GetRandomFileName() + Path.GetExtension(file);
    File.Copy(file, $"{dest_path}{name}");
}