using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine();
            //FORMATAÇÃO
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine();

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            // DateTime y2 = x.Add(timeSpan);
            DateTime y3 = x.AddDays(3);
            DateTime y4 = x.AddHours(2);
            // DateTime y5 = x.AddMilliseconds(double);
            // DateTime y6 = x.AddMinutes(double);
            // DateTime y7 = x.AddMonths(int);
            // DateTime y8 = x.AddSeconds(double);
            // DateTime y9 = x.AddTicks(long);
            // DateTime y10 = x.AddYears(int);
            // DateTime y11 = x.Subtract(timeSpan);
            TimeSpan t12 = x.Subtract(y4);

            Console.WriteLine(x);
            Console.WriteLine(y3);
            Console.WriteLine(t12);

        }
    }
}