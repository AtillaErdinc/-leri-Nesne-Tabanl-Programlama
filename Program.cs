using System;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* 
               Hocam merhaba, 9*9'luk çarpım tablosu hazırladım. Matrislerle yapacaktım ama ilk bunu denemek
              istedim. İşlemler doğru, satir ve sutun dizilerinin eleman sayıları eşitse n*n'lik bütün tabloları
              doğru şekilde hesaplıyor program ama çıktı ekranı kayıyor. Onu kontrol edemiyorum. 3*3'lük tabloya 
              kadar her şey yolunda gidiyor. 3*4=12'den sonra 2 karakterli sonuçlar başladığından sonuçları hizalı
              gelmiyor.
            */
            int kontrol = 1;
            int[] satir = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] sutun = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("x ");

            for (int a = 0; a < satir.Length; a++)
            {
                Console.Write("{0} ", satir[a] * sutun[kontrol]);

                if (a == satir.Length-1)
                {
                    Console.Write("\n");
                }
            }

            for (int a = 0; a < satir.Length; a++)
            {
                Console.Write("{0} ",kontrol - 1);
                kontrol++;
                
                for(int b = 0; b < sutun.Length; b++)
                {
                    Console.Write("{0} ", satir[a] * sutun[b]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        
    }
}
