using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taban_dönüstürme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tabandönusturme


            /* int sayi = Convert.ToInt32(Console.ReadLine());
             int sonuc = 0;
             int basamak = 1;
             while (sayi > 0)
             {
                 sonuc += (sayi % 2) * basamak;
                 basamak *= 10;
                 sayi /= 2;
             }
             Console.WriteLine(sonuc);
             Console.ReadKey();*/
            #endregion

            #region tahminEtver1.0.0.1
            /* Console.WriteLine("[1-100] arasında bir sayı tuttum tahmin et ne ?");
             Random rnd = new Random();
             int rasgeleSayi = rnd.Next(1, 101);
             int tahmin, counter = 0;
             while (true)
             {
                 counter++;
                 Console.Write("Tahmin Ne : ");
                 tahmin = Convert.ToInt32(Console.ReadLine());
                 if (tahmin < rasgeleSayi)
                 {
                     Console.WriteLine("Daha Büyük Tahmin Yap");
                 }
                 else if (tahmin > rasgeleSayi)
                 {

                     Console.WriteLine("Daha Küçük Tahmin Yap");
                 }
                 else
                 {
                     break;
                 }
             }
             Console.WriteLine("\n tebrikler.. {0}. adımda bildin",counter);

             Console.ReadKey();*/


            #endregion


            #region girilensayidanöncekitekleritoplayan

            
           /* Console.Write("Sayı Girin: ");
            int sayi =Convert.ToInt32( Console.ReadLine());
            int counter = 0;
            Console.Write("İşlem Seçiniz : ");
           string islem=Console.ReadLine();
            int toplamsonuc = 0, carpimsonuc = 1;
            while (counter<=sayi)
            {
                if (counter % 2 == 1)
                {
                    toplamsonuc = toplamsonuc + counter;
                    carpimsonuc = carpimsonuc * counter;
                }
                counter++;
            }
            if (islem == "topla")
            {
                Console.WriteLine(toplamsonuc);

            }
            else if (islem == "çarp")
            {
                
                Console.WriteLine(carpimsonuc);
            }
            else
            {
                Console.WriteLine(islem + " ne?? ");

            }
            Console.ReadKey();*/
            #endregion
          

        }
    }
}
