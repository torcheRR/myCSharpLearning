// do while döngüsü

// int i =1;
//
// do
// {
//     Console.WriteLine(i);
//     i++;
// } while (false);


Console.Write("Adet: ");
int adet = Convert.ToInt32(Console.ReadLine());

string[] isimler = new string[adet];

int i = 0;

do
{
    Console.Write("Ürün adı: ");
    isimler[i] = Console.ReadLine() ?? "";

    i++;

} while (adet!=i);

Console.WriteLine("ürünler listeleniyor...");

for (int a = 0; a < isimler.Length; a++)
{
    Console.WriteLine(isimler[a]);
}