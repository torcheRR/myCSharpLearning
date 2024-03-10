namespace ConsoleApp1;

internal class Program
{
    private static void parola_kontrol(string password)
    {
        if (password.Length <= 6 || password.Length >= 10)
            throw new Exception("parola 6-10 karakter aralığında olmalıdır.");

        if (!password.Any(char.IsDigit)) throw new Exception("parola en az bir rakam içermelidir.");

        if (!password.Any(char.IsLetter)) throw new Exception("parola en az bir harf içermelidir.");
    }


    private static void Main(string[] args)
    {
        Console.Write("Parola: ");
        var parola = Console.ReadLine();

        try
        {
            parola_kontrol(parola);
            Console.WriteLine("Parola geçerlidir.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}