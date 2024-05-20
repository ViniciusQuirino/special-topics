using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //base para datetimenow

            DateTime d2 = new DateTime();

            // DateTime(ano, mes, dia)
            // DateTime(ano, mes, dia, hora, minuto, segundo)
            // DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo)

            DateTime a1 = new DateTime(2000, 8, 15);
            DateTime b2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(a1);
            Console.WriteLine(b2);
            Console.WriteLine(d3);

            DateTime m1 = DateTime.Now;
            DateTime m2 = DateTime.UtcNow;
            DateTime m3 = DateTime.Today;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);

            DateTime n1 = DateTime.Parse("2000-08-15");
            DateTime n2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime n3 = DateTime.Parse("15/08/2000");
            DateTime n4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);


            DateTime e1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
CultureInfo.InvariantCulture);
            DateTime e2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}