using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            odev();
        }
        static void odev()
        {
            int islem;
            BASADON:
            Console.Write("İşlem seçiniz:\n\n1- 5'e bölünebilen sayıları ekrana yazdırma örneği\n2- Overload metod örneği\n\nSeçimimiz:");
            islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {

                case 1:

                    Console.Clear();
                    Console.Write("İlk sayıyı giriniz: ");
                    int ilkSayi = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nİkinci sayıyı giriniz: ");
                    int ikinciSayi = Convert.ToInt32(Console.ReadLine());
                    besebolunen(ilkSayi, ikinciSayi);

                    break;

                case 2:

                    Console.WriteLine("Kaç tane sayıyı ard arda çarpmak istersiniz? (2 veya 3 olmalı)");
                    int kontrol = Convert.ToInt32(Console.ReadLine());

                    if (kontrol == 2)
                    {
                        Console.Clear();
                        Console.Write("İlk sayıyı giriniz:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nİkinci sayıyı giriniz:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        sayilaricarp(a,b);
                    }
                    else if (kontrol == 3)
                    {
                        Console.Clear();
                        Console.Write("İlk sayıyı giriniz:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nİkinci sayıyı giriniz:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nÜçüncü sayıyı giriniz:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        sayilaricarp(a, b,c);
                    }

                    break;

                default:

                    goto BASADON;
            }

        }

        static void besebolunen(int a, int b)
        {
            Console.Clear();
            Console.WriteLine("Girdiğiniz aralıktaki beşe tam bölünebilen sayılar:\n");

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int sayac = 0;

            for(int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    sayac++;
                }
            }

            if (sayac == 0)
            {
                Console.WriteLine("Girdiğiniz aralıkta beşe tam bölünebilen sayı bulunmuyor.");
            }

            Console.WriteLine("\nİşlem seçim ekranına dönmek için 1'e basınız.");
            int kontrol = Convert.ToInt32(Console.ReadLine());
            switch (kontrol)
            {
                case 1:
                    Console.Clear();
                    odev();
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nGirdiğiniz değeri kontrol ederek tekrar giriniz.");
                    odev();
                break;
            }
        }
        
        static void sayilaricarp(int a, int b)
        {
            Console.Clear();
            Console.WriteLine("Sonuç= {0} --Bu sonuç iki parametreli sayilaricarp metoduyla bulundu.--", a * b);
            Console.WriteLine("\nİşlem seçim ekranına dönmek için 1'e basınız.");
            int kontrol = Convert.ToInt32(Console.ReadLine());
            switch (kontrol)
            {
                case 1:
                    Console.Clear();
                    odev();
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nGirdiğiniz değeri kontrol ederek tekrar giriniz.");
                    odev();
                break;

            }
        }

        static void sayilaricarp(int a, int b,int c)
        {
            Console.Clear();
            Console.WriteLine("Sonuç= {0} --Bu sonuç üç parametreli sayilaricarp metoduyla bulundu.--", a * b * c);
            Console.WriteLine("\nİşlem seçim ekranına dönmek için 1'e basınız.");
            int kontrol = Convert.ToInt32(Console.ReadLine());
            switch (kontrol)
            {
                case 1:
                    Console.Clear();
                    odev();
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nGirdiğiniz değeri kontrol ederek tekrar giriniz.");
                    odev();
                break;
            }
        }
    }
}

