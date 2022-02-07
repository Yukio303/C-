﻿using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //günün tarihi
            Console.WriteLine(DateTime.Now.Date); //gün-ay-yıl
            Console.WriteLine(DateTime.Now.Day); //gün
            Console.WriteLine(DateTime.Now.Month); //ay
            Console.WriteLine(DateTime.Now.Year); //yıl
            Console.WriteLine(DateTime.Now.Hour); //saat
            Console.WriteLine(DateTime.Now.Minute); //dakika
            Console.WriteLine(DateTime.Now.Second); //saniye

            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın hangi günü
            Console.WriteLine(DateTime.Now.DayOfYear); //yılın kaçıncı günü

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime format

            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //04
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021


            Console.WriteLine("*****Math Kütüphanesi*****");
            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); // 25;
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            
            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Round(22.3)); // 22;
            Console.WriteLine(Math.Round(22.7)); // 23;
            Console.WriteLine(Math.Round(22.5)); // 22;
            Console.WriteLine(Math.Floor(22.7)); // 22;
            
            Console.WriteLine(Math.Max(2,6)); // 6;
            Console.WriteLine(Math.Min(2,6)); // 2;

            Console.WriteLine(Math.Pow(3,4)); // 3^4;
            Console.WriteLine(Math.Sqrt(9)); // 3;
            Console.WriteLine(Math.Log(9)); // ln(9);
            Console.WriteLine(Math.Exp(3)); // e^3;
            Console.WriteLine(Math.Log10(10)); // 10 tabanında log(10);
        }
    }
}
