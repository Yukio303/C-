using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama işlemleri

            Console.WriteLine("****Atama işlemleri****");

            int x = 3;
            int y = 3;
            y = y+2;
            x += 2;
            Console.WriteLine(y);
            Console.WriteLine(x);

            y/=2;
            x*=2;
            Console.WriteLine(y);
            Console.WriteLine(x);

            //Mantıksal Operatörler

            Console.WriteLine("****Mantıksal Operatörler****");

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            //İlişkisel Operatörler
            //<, >, <=, >=, ==, !=

            Console.WriteLine("****İlişkisel Operatörler****");

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);

            sonuc = a>b;
            Console.WriteLine(sonuc);

            sonuc = a<=b;
            Console.WriteLine(sonuc);

            sonuc = a>=b;
            Console.WriteLine(sonuc);

            sonuc = a==b;
            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler

            Console.WriteLine("****Aritmetik Operatörler****");

            int sayi1 = 5;
            int sayi2 = 10;

            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1+= 1;
            Console.WriteLine(sayi1);

            //% : mod alır

            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2); 


        }
    }
}
