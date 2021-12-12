using System;

namespace Metotlar1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYaz(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArtirveTopla(ref a, ref b);
            ornek.EkranaYaz(Convert.ToString(sonuc2));
            ornek.EkranaYaz(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArtirveTopla(ref int d1, ref int d2)
        {
            d1 += 1;
            d2+= 2;

            return d1 + d2; 
        }
    }
}