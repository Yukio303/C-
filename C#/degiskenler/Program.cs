using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     // 1 byte ==> 0_255
            sbyte c = 5;    // 1 byte ==> -128 _ 127
            
            short s = 5;    // 2 byte ==> -32768 _ 32768
            ushort us = 5;  // 2 byte ==> 0 _ 65365

            Int16 i16 = 2;  // 2 byte
            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 4;     // 8 byte
            ulong ul = 4;   // 8 byte

            // reel sayılar
            float f = 5;    // 4 byte
            double d = 5;   // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';  // 2 byte
            string st = "2"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            
            Console.Write(dt); 

            object o1 = "x";
            object o2 = 'y';
            object o3 = 1;
            object o4 = 3.4;


            // Stringler

            string strl = string.Empty;
            strl = "Kerem Aka";
            string ad = "Kerem";
            string soyad = "Aka";
            string tam_isim = ad + " " + soyad;

            // Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeni_deger = str20 + int20.ToString();

            int int21 = int20 + Convert.ToInt32(str20);

            int int22 = int20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");

            string hour = DateTime.Now.ToString("HH:mm");
            



        }
    }
}
