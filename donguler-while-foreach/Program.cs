﻿using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // //while
            // // 1 den başlayarak konsolda girilen sayıya kadar (sayı dahil) ortalama hesaplayıp konsola yazdıran program
            // Console.WriteLine("lütfen bir sayı giriniz: ");            
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while(sayac <= sayi)
            // {
            //     toplam += sayac;
            //     sayac++; 
            // }
            // Console.WriteLine(toplam/sayi);

            // //a dan z ye kadar tüm harfleri konsola yazdır
            // char character = 'a';
            // while(character <= 'z')
            // {
            //     Console.WriteLine(character);
            //     character++;
            // }
            Console.WriteLine("****Foreach****");

            string [] arabalar = {"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
                
            }
        }

    }
}
