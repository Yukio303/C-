using System;

namespace part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir pozitif sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            if(n<1)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                n = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"Lütfen {n} tane kelime giriniz: ");

            string[] list = new string[n];
            for(int i = 0; i < n; i++)
            {
                string kelime = Console.ReadLine();
                list[i] = kelime;

            }

            Metotlar instance = new Metotlar();

            Console.WriteLine("****Kelimeler****");

            instance.stringYazdir(list, n);
            
        }
    }

    public class Metotlar
    {
        public void stringYazdir(string[] list, int n)
        {
            Array.Reverse(list);

            foreach (var st in list)
            {
                Console.WriteLine(st);
            }

        }
    }
}
