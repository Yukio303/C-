﻿using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları yazdır
            // Console.WriteLine("Lütfen bir sayı giriniz: ");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i < sayac; i++)
            // {
            //     if(i%2==1)
            //         Console.WriteLine(i);
            // }

            // //1 ile 1000 arasındaki çift ve tek sayıların kendi aralarında toplamları
            // int tekToplam = 0;
            // int ciftToplam = 0;

            // for (int i = 0; i <= 1000; i++)
            // {
            //     if(i%2 == 1)
            //         tekToplam += i;
                
            //     else
            //         ciftToplam += i;
                
            // }
            // Console.WriteLine("tekToplam: " + tekToplam);
            // Console.WriteLine("ciftToplam: " + ciftToplam);

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
            }            
        }

    }
}
