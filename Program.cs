using System;
using System.Security.Cryptography.X509Certificates;

namespace TahminOyunu
{
    class Program
    {
        public static void Main(string[] args)
        {

            Random random = new Random();
            int sayi;
            int tahmin;
            int tahminler;
            bool tekrarOyna = true;
            int min = 1;
            int max = 100;
            string yanit;

            while (tekrarOyna)
            {
                tahmin = 0;
                tahminler = 0;
                sayi = random.Next(min, max + 1);

                while (tahmin != sayi)
                {
                    Console.WriteLine("lütfen " + min + " ile " + max + "arasında bir sayı giriniz : ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("tahmin : " + tahmin);
                    
                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Tahmin sayıdan yüksek");
                    }
                    else if (tahmin < sayi)
                    {
                        Console.WriteLine("Tahmin sayıdan düşük");
                    }
                    tahminler++;

                }

                Console.WriteLine("sayi : " + sayi);
                Console.WriteLine("Kazandınız");
                Console.WriteLine("Tahmin sayınız: " + tahminler);
                Console.WriteLine("Tekrar oynamak ister misiniz ? (E / H ) ");
                yanit = Console.ReadLine();
                yanit = yanit.ToUpper();

                if (yanit == "E")
                {
                    tekrarOyna = true;

                }
                else
                {
                    tekrarOyna = false;
                }
            }
            Console.WriteLine("çıkış yapılıyor");


            Console.ReadKey();
        }
    }
}