// File


// Directory.CreateDirectory("Temp");

// Directory.CreateDirectory("Temp/deneme");
// Directory.CreateDirectory("Temp/deneme2");




// if(Directory.Exists("Temp/deneme2")){
//     Directory.Delete("Temp/deneme2");
// }
// else{
//     System.Console.WriteLine("silmek istediğiniz klasör yok.");
//     }


// string path = "/Users/berkayocer/Desktop/github/myCSharpLearning/c#/10.2_File/Temp/deneme2";
string path = Directory.GetCurrentDirectory()+ "/Temp";

System.Console.WriteLine(path);

Directory.CreateDirectory(path);

