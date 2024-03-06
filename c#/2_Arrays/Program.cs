/*
        Arrays: Diziler
*/ 

string[] isimler = new string[5];

isimler[0]="Yaren";
isimler[1]="Berkay";
isimler[2]="Gökay";
isimler[3]="Nilay";
isimler[4]="Selenay";



System.Console.WriteLine();

int[] numaralar = new int[]{1,2,3,4,5};

for( int i =0; i<5; i++){
System.Console.WriteLine($"{isimler[i]} isimli kişinin numarası {numaralar[i]}'dir.");
}
