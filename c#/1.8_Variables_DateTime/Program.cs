/*
            DateTime
*/

var simdi = DateTime.Now;

System.Console.WriteLine(simdi);
System.Console.WriteLine(simdi.Year);
System.Console.WriteLine(simdi.Month);
System.Console.WriteLine(simdi.Day);
System.Console.WriteLine(simdi.DayOfWeek);
System.Console.WriteLine(simdi.DayOfYear);
System.Console.WriteLine(simdi.Hour);
System.Console.WriteLine(simdi.Minute);
System.Console.WriteLine(simdi.Second);



DateTime date = new DateTime(2003,11,14,12,00,00);

System.Console.WriteLine(date);

DateTime date2 = date.AddHours(1);

DateTime date3 = DateTime.Now;

var fark = (date3 - date);

System.Console.WriteLine((fark.TotalDays)/365);