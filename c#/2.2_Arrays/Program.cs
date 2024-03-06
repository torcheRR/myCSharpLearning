// Array Slicing

string[] sehirler = {"zonguldak","rize","kocaeli","istanbul","ankara"};

var sonuc = sehirler[0..3];

System.Console.WriteLine(sehirler.Length);

System.Console.WriteLine(sonuc.Length);

System.Console.WriteLine(sonuc[0]);

System.Console.WriteLine(sonuc[1]);

System.Console.WriteLine(sonuc[2]);


System.Console.WriteLine();


// foreach(var sehir in sehirler){
//     System.Console.WriteLine(sehir);
// }

foreach (var sehir in sehirler[..3]){
    System.Console.WriteLine(sehir);
}

System.Console.WriteLine();

string berkay ="Berkay";

System.Console.WriteLine(berkay[..3]);