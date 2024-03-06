// Array Methods : Dizi Metodları

string[] sehirler = {"istanbul", "giresun", "sivas"};
int[] plakalar = {52,2,4,7};

// sehirler[0]="Sakarya";

sehirler.SetValue("eskişehir",0);


// System.Console.WriteLine(sehirler[0]);

System.Console.WriteLine(sehirler.GetValue(1));

System.Console.WriteLine(sehirler.Length);

System.Console.WriteLine(Array.IndexOf(sehirler,"sivas"));


System.Console.WriteLine();
System.Console.WriteLine();

Array.Sort(sehirler);
Array.Sort(plakalar);


Array.Clear(sehirler);
Array.Clear(plakalar,0,1);

System.Console.WriteLine(sehirler.GetValue(0));
System.Console.WriteLine(sehirler[1]);


System.Console.WriteLine(plakalar.GetValue(0));
System.Console.WriteLine(plakalar[1]);
System.Console.WriteLine(plakalar[2]);
