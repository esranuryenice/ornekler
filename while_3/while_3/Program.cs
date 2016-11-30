using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region sayiyitoplayanişlemseçtiren


            bool devam = true;
            while (devam)
            {
                Console.Write("Birinci Sayı : ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci Sayı : ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İşlem Seç : ");
                char islem = Convert.ToChar(Console.ReadLine());

                double sonuc = 0;
                switch (islem)
                {
                    case '+':
                        sonuc = sayi1 + sayi2;
                        break;
                    case '-':
                        sonuc = sayi1 - sayi2;
                        break;
                    case '*':
                        sonuc = sayi1 * sayi2;
                        break;
                    case '/':
                        sonuc = sayi1 / sayi2;
                        break;
                    default:
                        Console.WriteLine("Böyle Bir işlem tipi yok");
                        break;
                }
                Console.WriteLine("Sonuc = " + sonuc);
                Console.WriteLine("Devam Edelim Mi?(Evet) ");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {

                    devam = true;

                }
                else
                {
                    devam = false;
                }
            }
            Console.WriteLine("Görüşmek Üzere");
            Console.ReadKey();
            #endregion










        }
    }
}
