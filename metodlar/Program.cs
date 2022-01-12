using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //erisim_belirteci geri_dönüt_tipi metot_adi(parametre_listesi/arguman)
           //{    
               ////komutlar;
               // return;
           //}

           int a = 2;
           int b = 3;

           Console.WriteLine(a+b);

           int sonuc = Topla(a,b);
           Console.WriteLine(sonuc);

           Metotlar ornek = new Metotlar();
           ornek.ekranayazdir(Convert.ToString(sonuc));

           int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
           Console.WriteLine(Convert.ToString(a+b));
           Console.WriteLine(Convert.ToString(sonuc2));

        }

        static int Topla(int deger1, int deger2)
        {
            return deger1+deger2;
        }


    }


    class Metotlar
    {
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;

            return deger1 + deger2;
        }

    }
}
