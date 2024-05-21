using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan(900000000L);
            Console.WriteLine(t2);

            TimeSpan ts1 = new TimeSpan(1, 2, 30); // 1 hora, 2 minutos, 30 segundos
            TimeSpan ts2 = new TimeSpan(2, 5, 30, 40); // 2 dias, 5 horas, 30 minutos, 40 segundos
            TimeSpan ts3 = new TimeSpan(3, 4, 5, 6, 700); // 3 dias, 4 horas, 5 minutos, 6 segundos, 700 milissegundos

            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine(ts3.Ticks);

            TimeSpan a1 = TimeSpan.FromDays(1.5); //um dia e meio
            TimeSpan a2 = TimeSpan.FromHours(1.5); //uma hora e meia
            TimeSpan a3 = TimeSpan.FromMinutes(1.5);
            TimeSpan a4 = TimeSpan.FromSeconds(1.5);
            TimeSpan a5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan a6 = TimeSpan.FromTicks(900000000L); //apenas inteiros
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
        }
    }
}