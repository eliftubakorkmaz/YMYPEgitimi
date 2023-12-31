﻿namespace _08.Oyun_SayiTahminEt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen isminizi giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz! " + name );
            Random rastgele = new();

            int sayi = rastgele.Next(1,10);
            int tahmin = 0;
            int deneme = 0;
          
            // for, foreach, while => break bu döngüyü kırıp çıkmanızı sağlar.
            // continue => bir defaya mahsus atlamamızı sağlar.
            while (sayi != tahmin)
            {
                Console.WriteLine("Lütfen 1-10 arasında bir sayı tahmin edin.");
                string tahminEdilenSayi = Console.ReadLine();

                if (int.TryParse(tahminEdilenSayi, out tahmin) == false)
                {
                    Console.WriteLine("Sadece rakam girilebilir.");
                    continue;
                }

                if (tahmin > 10 )
                {
                    Console.WriteLine("Sadece 1-10 arası rakam yazabilirsiniz.");
                    continue;
                }

                Console.WriteLine("Tahmininiz: " + tahminEdilenSayi);

                if (sayi == tahmin)
                {
                    //Console.WriteLine("Tebrikler. Tuttuğum sayıyı " + deneme + " buldunuz.");
                    Console.WriteLine($"Tebrikler. Tuttuğum sayıyı {deneme} buldunuz.");
                    tahmin = sayi;
                    continue;
                }
                else
                {
                    Console.WriteLine("Tuttuğum sayıyı bilemediniz.");
                    deneme++;
                }
            }
        }
    }
}