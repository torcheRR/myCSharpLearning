﻿// Switch case

int ay = DateTime.Now.Month;

switch (ay)
{
    case 12:
        case 1:
        case 2:
            Console.WriteLine("Kış");
        break;
    case 3:
        case 4:
        case 5:
            Console.WriteLine("İlkbahar");
        break;
    case 6:
        case 7:
        case 8:
            Console.WriteLine("Yaz");
        break;
    case 9:
        case 10:
        case 11:
            Console.WriteLine("Sonbahar");
        break;
    
    default:
        Console.WriteLine("hatalı ay bilgisi");
        break;
}
