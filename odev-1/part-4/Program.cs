using System;

namespace part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız: ");

            string cumle = Console.ReadLine();

            char[] list = cumle.ToCharArray();

            int harf = 0;
            int kelime = 1;

            foreach (var karakter in list)
            {
                if(karakter == ' ')
                {
                    kelime++;
                }

                else if(Char.IsPunctuation(karakter))
                {
                    continue;
                }

                else
                {
                    harf++;
                } 
            }

            Console.WriteLine("****Sonuçlar****");
            Console.WriteLine($"Cümlede {kelime} tane kelime vardır.");
            Console.WriteLine($"Cümlede {harf} tane harf vardır.");

        }
    }
}
