using System;
using System.Linq;

namespace Proje
{
    class Program
    {   
        static void Main(string[] args)
        {     
            menu();
        }

        static void menu()
        {
            Console.WriteLine("İşlem seçiniz:");
            Console.WriteLine("\nCEBİR : \n\n 1- EBOB\n 2- EKOK\n 3- Çarpanlara Ayırma\n 4- Aritmatik Ortalama\n 5- Geometrik Ortalama\n 6- 1. Dereceden Fonksiyon (ax+b)\n 7- 2. Dereceden Fonksiyon (ax²+bx+c)\n 8- İkinci Dereceden Denklemin Kökleri\n\nGEOMETRİ:\n\n 9- Çevresi Bilinen Çemberin Yarıçapı\n10- Çemberin Çevresi\n11- Çemberin Alanı\n12- Sinüs Alan Teoremi\n13- Cosinüs Teoremi\n14- Noktanın Orjine Uzaklığı\n15- Noktanın Noktaya Uzaklığı\n16- Noktanın Doğruya Uzaklığı\n17- Doğrunun Ekseni Kestiği Noktalar İle Orjin Arasında Kalan Alan");
            Console.Write("\nSeçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                ebob();
            }
            else if (secim == 2)
            {
                ekok();
            }
            else if (secim == 3)
            {
                asal();
            }
            else if (secim == 4)
            {
                a_ort();
            }
            else if (secim == 5)
            {
                g_ort();
            }
            else if (secim == 6)
            {
                f_1();
            }
            else if (secim == 7)
            {
                f_2();
            }
            else if (secim == 8)
            {
                k_2();
            }
            else if (secim == 9)
            {
                cember_r();
            }
            else if (secim == 10)
            {
                cember_c();
            }
            else if (secim == 11)
            {
                cember_a();
            }
            else if (secim == 12)
            {
                sinus();
            }
            else if (secim == 13)
            {
                cosinus();
            }
            else if (secim == 14)
            {
                analitik_nokta();
            }
            else if (secim == 15)
            {
                analitik_nokta2();
            }
            else if (secim == 16)
            {
                analitik_nokta3();
            }
            else if (secim == 17)
            {
                analitik_alan();
            }
            else
            {
                Console.Clear();

                Console.WriteLine("Geçersiz işlem seçtiniz.\n");

                menu();
            }
        }

        static void sor()
        {
        SOR:
            Console.WriteLine("\n\n\nMenü: 1 Çıkış: 2");
            Console.Write("\nSeçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.Clear();
                menu();
            }
            else if (secim == 2)
            {

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Geçerli seçim yapmadınız. Lütfen tekrar seçiniz.\n");
                goto SOR;
            }
        }
        
        static void ebob()
        {
            int secim2 = 0;
            
            Console.Clear();
            Console.Write("Kaç adet sayının EBOB'unu incelemek istiyorsunuz: ");
            secim2 = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[secim2];

            Console.Clear();

            for(int i = 0; i < secim2; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            int maxValue = sayilar.Max();
            int sonuc = 1;

            for (int bolen = 2; bolen <= maxValue; bolen++)
            {
                TEKRAR:
                int kontrol = 0;
                int kontrol1 = 0;

                for(int index = 0; index < sayilar.Length; index++)
                {
                    if (sayilar[index] % bolen == 0)
                    {
                        sayilar[index] = sayilar[index] / bolen;
                        kontrol++;
                    }
                }
                if (kontrol == sayilar.Length)
                {
                    sonuc = sonuc * bolen;
                }
                for(int index = 0; index < sayilar.Length; index++)
                {
                    if (sayilar[index] % bolen == 0)
                    {
                        kontrol1++;
                    }
                }
                if (kontrol1 > 0)
                {
                    goto TEKRAR;
                }
            }

            Console.WriteLine("\nGirdiğiniz sayıların en büyük ortak böleni = {0}",sonuc);
            sor();
            }

        static void ekok()
        {
            int secim3 = 0;

            Console.Clear();
            Console.Write("Kaç adet sayının EKOK'unu incelemek istiyorsunuz: ");
            secim3 = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[secim3];

            Console.Clear();

            for (int i = 0; i < secim3; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }


            int maxValue = sayilar.Max();
            int sonuc = 1;

            for (int bolen = 2; bolen <= maxValue; bolen++)
            {

            TEKRAR:

                int kontrol = 0;
                int kontrol1 = 0;

                for (int index = 0; index < sayilar.Length; index++)
                {
                    if (sayilar[index] % bolen == 0)
                    {
                        sayilar[index] = sayilar[index] / bolen;
                        kontrol++;
                    }
                }
                if (kontrol > 0)
                {
                    sonuc = sonuc * bolen;
                }
                for (int index = 0; index < sayilar.Length; index++)
                {
                    if (sayilar[index] % bolen == 0)
                    {
                        kontrol1++;
                    }
                }
                if (kontrol1 > 0)
                {
                    goto TEKRAR;
                }
            }

            Console.WriteLine("\nGirdiğiniz sayıların en küçük ortak katı = {0}", sonuc);

            sor();
        }

        static void asal()
        {
            Console.Clear();
            Console.Write("Çarpanlarına ayırmak istediğiniz sayıyı giriniz: ");
            long sayi = Convert.ToInt64(Console.ReadLine());
            long sayi2 = sayi;
            Console.Write("1 ");

            for (int bolen = 2; bolen <= sayi; bolen++)
            {
            TEKRAR:

                if (sayi % bolen == 0)
                {
                    sayi = sayi / bolen;
                    Console.Write("x {0} ", bolen);
                    if (sayi % bolen == 0)
                    {
                        goto TEKRAR;
                    }
                }
            }

            Console.Write("= {0}", sayi2);

            sor();
        }

        static void a_ort()
        {
            Console.Clear();
            Console.Write("Kaç adet sayının aritmatik ortalamasını almak istersiniz:  ");
            int adet = Convert.ToInt32(Console.ReadLine());
            double toplam = 0;

            for (int i = 1; i <= adet; i++)
            {
                Console.Clear();
                Console.Write("{0}. sayıyı giriniz: ",i);
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }

            Console.Clear();
            Console.WriteLine("Girdiğiniz sayıların aritmatik ortalaması = {0}", toplam / adet);

            sor();
        }

        static void g_ort()
        {
            Console.Clear();
            Console.Write("Kaç adet sayının aritmatik ortalamasını almak istersiniz:  ");
            double adet = Convert.ToDouble(Console.ReadLine());
            double carpim = 1;

            for (int i = 1; i <= adet; i++)
            {
                Console.Clear();
                Console.Write("{0}. sayıyı giriniz: ", i);
                int sayi = Convert.ToInt32(Console.ReadLine());
                carpim = carpim * sayi;
            }

            double us = 1/adet;
            double geometrik_ortalama = Math.Pow(carpim,us);
            Console.Clear();
            Console.WriteLine("Girdiğiniz sayıların geometrik ortalaması = {0}", geometrik_ortalama);

            sor();
        }

        static void f_1()
        {
            Console.Clear();
            Console.Write("f(x) = ax+b şeklindeki fonksiyonu tanımlamak için a ve b değerlerini giriniz.\n\na değeri = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nb değeri = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nx değişkemi giriniz = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("f({0}) = {1} olarak hesaplanır.", x, (a * x) + b);

            sor();
        }

        static void f_2()
        {
            Console.Clear();
            Console.Write("f(x) = ax²+bx+c şeklindeki fonksiyonu tanımlamak için a, b ve c değerlerini giriniz.\n\na değeri = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nb değeri = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nc değeri = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nx değişkemi giriniz = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("f({0}) = {1} olarak hesaplanır.", x, ((a*x*x)+(b*x)+c));

            sor();
        }

        static void k_2()
        {
            Console.Clear();
            Console.Write("ax²+bx+c şeklindeki denklemin köklerini hesaplamak için a, b ve c değerlerini giriniz.\n\na değeri = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nb değeri = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nc değeri = ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double d = (b * b) - (4 * a * c);

            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Denklemin İki Kökü Vardır = ");
                Console.WriteLine("x1 =" + x1);
                Console.WriteLine("x2 =" + x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Denklemin Bir Kökü Vardır = ");
                Console.WriteLine("x =" + x);
            }
            else
            {
                Console.Write("Sanal Kök Vardır");
            }

            sor();
        }

        static void cember_r()
        {
            double pi = Math.PI;
            Console.Clear();
            Console.Write("Çemberin çevre uzunluğunu giriniz: ");
            double cevre = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nÇevre uzunluğunu girdiğiniz çemberin yarıçapı = {0}",cevre/(2*pi));

            sor();
        }

        static void cember_c()
        {
            double pi = Math.PI;
            Console.Clear();
            Console.Write("Çevresini bulmak istediğiniz çemberin yarıçap uzunluğunu giriniz: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nYarıçap uzunluğunu girdiğiniz çemberin çevresi = {0}",2*pi*r);

            sor();
        }

        static void cember_a()
        {
            double pi = Math.PI;
            Console.Clear();
            Console.Write("Alanını bulmak istediğiniz çemberin yarıçap uzunluğunu giriniz: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nYarıçap uzunluğunu girdiğiniz çemberin alanı = {0}",(pi*r*r));

            sor();
        }

        static void sinus()
        {
            Console.Clear();
            Console.Write("Sinüs alan teoremi uygulanacak açı değerini giriniz: ");
            double aci = Convert.ToDouble(Console.ReadLine());

            double sinaci = Math.Sin(aci);

            Console.Write("\nAçıya komşu olan kenar uzunluğunu giriniz: ");
            double kenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nAçıya komşu olan diğer kenar uzunluğunu giriniz: ");
            double kenar2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nGirdiğiniz değerlere göre oluşan üçgenin alanı = {0}",0.5*sinaci*kenar*kenar2);

            sor();
        }

        static void cosinus()
        {
            Console.Clear();
            Console.Write("Cosinus teoremi uygulanacak açı değerini giriniz: ");
            double aci = Convert.ToDouble(Console.ReadLine());

            double cosaci = Math.Cos(aci);

            Console.Write("\nAçıya komşu olan kenar uzunluğunu giriniz: ");
            double kenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nAçıya komşu olan diğer kenar uzunluğunu giriniz: ");
            double kenar2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = (kenar * kenar) + (kenar2 * kenar2) - (2 * kenar * kenar2 * cosaci);

            Console.Write("Girdiğiniz değerlere göre oluşan üçgende girilen açının karşısındaki kenar uzunluğu = {0}",Math.Sqrt(sonuc));

            sor();
        }

        static void analitik_nokta()
        {
            Console.Clear();
            Console.Write("Orjine olan uzaklığını bulmak istediğiniz noktanın x değerini giriniz: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nOrjine olan uzaklığını bulmak istediğiniz noktanın y değerini giriniz: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double uzunluk = Math.Sqrt(((x * x) + (y * y)));

            Console.Write("\n\n({0},{1}) noktasının orjine olan uzaklığı {2} birimdir.",x,y,uzunluk);

            sor();
        }

        static void analitik_nokta2()
        {
            Console.Clear();
            Console.Write("İlk noktanın x değerini giriniz: ");
            double x_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nİlk noktanın y değerini giriniz: ");
            double y_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nİkinci noktanın x değerini giriniz: ");
            double x_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nİkinci noktanın y değerini giriniz: ");
            double y_2 = Convert.ToDouble(Console.ReadLine());

            double uzunluk = Math.Sqrt((x_1-x_2)*(x_1-x_2)+(y_1-y_2)*(y_1-y_2));

            Console.Write("\n\n({0},{1}) noktasının ({2},{3}) noktasına olan uzaklığı {4} birimdir.",x_1,y_1,x_2,y_2,uzunluk);

            sor();
        }

        static void analitik_nokta3()
        {
            Console.Clear();
            Console.Write("Doğruya olan uzaklığını incelemek istediğiniz noktanın x değerini giriniz: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDoğruya olan uzaklığını incelemek istediğiniz noktanın y değerini giriniz: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nNoktaya göre uzaklığı bulunacak ax+by+c doğrusunun;\n\na değerini giriniz: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nb değerini giriniz: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nc değerini giriniz: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double uzunluk = Math.Abs((a * x) + (b * y) + c) / Math.Sqrt((a * a) + (b * b));

            Console.Write("\n\n({0},{1}) noktasının ({2})x + ({3})y + ({4})c doğrusuna olan uzaklığı {5} birimdir.", x, y, a, b, c, uzunluk);

            sor();
        }

        static void analitik_alan()
        {
            Console.Clear();
            Console.Write("Noktaya göre uzaklığı bulunacak ax+by+c doğrusunun;\n\na değerini giriniz: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nb değerini giriniz: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nc değerini giriniz: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x_kesim = ((-1) * c) / a;
            double y_kesim = ((-1) * c) / b;

            double alan = (x_kesim * y_kesim) / 2;

            Console.Write("\nParametrelerini girdiğiniz doğrunun x ve y eksenleri kestiği noktayla orjin arasında kalan alan {0} birim karedir. ",Math.Abs(alan));

            sor();
        }
    }
    }

