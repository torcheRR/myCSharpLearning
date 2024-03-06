// Karşılaştırma Operatörleri


int a = 7, b = 7, c = 10, d = 3;
var username = "berkayocer";
var password = "1234";

var sonuc = (a == b); //true
sonuc = (c == d); // false
sonuc = (username == "berkaocer"); //true
sonuc = (password == "12345"); //false

sonuc = (a != b);
sonuc = (a > c);
sonuc = (a < c);
sonuc = (a >= b);

//ternary
var sonuc2 = (a > b) ? "a büyük" : (a == b) ? "a ve b eşit" : "b büyük";

Console.WriteLine(sonuc2);