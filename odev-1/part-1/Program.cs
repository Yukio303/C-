using System;

namespace part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] list = new int[n]; 
            Console.WriteLine($"Lütfen {n} tane pozitif sayı giriniz: ");
            
            for (int i = 0; i < n; i++)
            {
                int sayi = int.Parse(Console.ReadLine());

                if(sayi < 1)
                {
                    Console.WriteLine("Pozitif olmayan birsayı girdiniz, lütfen pozitif bir sayı giriniz!");
                    i--;
                    continue;
                }

                else
                {
                    list[i] = sayi;
                }
                
            }
            Console.WriteLine("****Çift sayılar****");
            foreach (var item in list)
            {
                if(item%2 == 0)
                    Console.WriteLine(item);
                
            }



        }
    }
}
