using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            Dikdortgen dikdortgen = new Dikdortgen(a,b);
            Console.Write("Dikdörtgenin yüksekliğini giriniz: ");
            dikdortgen.boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDikdörtgenin taban uzunluğunu giriniz: ");
            dikdortgen.en = Convert.ToDouble(Console.ReadLine());
            alanhesapla(dikdortgen.en,dikdortgen.boy);
            cevreesapla(dikdortgen.en, dikdortgen.boy);
            Console.ReadKey();

        }
        static void alanhesapla(double en,double boy)
        {            
            Console.WriteLine("\nGirdiğniiz değerleri taşıyan dikdörtgenin alanı= {0}",en*boy);
        }
        static void cevreesapla(double en, double boy)
        {
            Console.WriteLine("\nGirdiğniiz değerleri taşıyan dikdörtgenin çevresi= {0}",2*(en+boy));
        }
    }
    class Dikdortgen
    {
        public double en;
        public double boy;

        public Dikdortgen(double h,double e)
        {
            boy = h;
            en = e;
        }
    }
}
