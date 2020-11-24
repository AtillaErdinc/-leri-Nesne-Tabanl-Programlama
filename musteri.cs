using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad2, soyad2, ogrno2, meslek2;
            int secim,yas2, maas2;
            ad2 = "1";
            soyad2 = "1";
            ogrno2 = "1";
            meslek2 = "1";
            yas2 = 1;
            maas2 = 1;

            Console.Write("Müşteri tipi seçiniz: 1-Öğrenci, 2-Müşteri\nSeçiminiz:");
            secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.Write("Adınız:");
                ad2 = Console.ReadLine();
                Console.Write("Soyadınız:");
                soyad2 = Console.ReadLine();
                Console.Write("Öğrenci numaranız:");
                ogrno2 = Console.ReadLine();
                Console.Write("Yaşınız:");
                yas2 = Convert.ToInt32(Console.ReadLine());

                musteri musteri = new musteri(ad2,soyad2,ogrno2,yas2);
                musteri.tanisOGR();
            }
            
            else if (secim == 2)
            {
                Console.Write("Adınız:");
                ad2 = Console.ReadLine();
                Console.Write("Soyadınız:");
                soyad2 = Console.ReadLine();
                Console.Write("Yaşınız:");
                yas2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mesleğiniz:");
                meslek2 = Console.ReadLine();
                Console.Write("Maaşınız:");
                maas2 = Convert.ToInt32(Console.ReadLine());

                musteri musteri = new musteri(ad2,soyad2,yas2,meslek2,maas2);
                musteri.tanisMSTR();
            }

                Console.ReadKey();

        }
    }
    class musteri
    {
        public string tip;
        public string ad;
        public string soyad;
        public string ogrNo;
        public int yas;
        public string meslek;
        public int maas;

        public musteri(string a, string b, string c, int d)
        {
            ad = a;
            soyad = b;
            ogrNo = c;
            yas = d;
        }

        public musteri(string a, string b, int c, string d, int e)
        {
            ad = a;
            soyad = b;
            yas = c;
            meslek = d;
            maas = e;
        }
        public void tanisOGR()
        {
            Console.WriteLine("{0} {1} {2} {3}", ad, soyad, ogrNo, yas);
        }
        public void tanisMSTR()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", ad, soyad, yas, meslek,maas);
        }
    }
}
