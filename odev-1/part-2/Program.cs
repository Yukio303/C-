using System;

namespace part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen iki pozitif sayı giriniz: ");
            
            int n = int.Parse(Console.ReadLine());
            if(n<1)
            {
                 Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                n = int.Parse(Console.ReadLine());
            }
               

            int m = int.Parse(Console.ReadLine());
            
            if(m<1)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                m = int.Parse(Console.ReadLine());
            }
                

            Console.WriteLine($"Lütfen {n} tane pozitif sayı giriniz: ");
            
            int[] list = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sayi = int.Parse(Console.ReadLine());

                if(sayi<1)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                    i--;
                }
                else
                {
                    list[i] = sayi;
                }     
            }

            Console.WriteLine("****Girdiğiniz sayıya tam bölünenler****");
            foreach (var sayi in list)
            {
                if(sayi%m == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
            
        }

    }

}   

        


    


