using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MusteriHizmetleri
            Console.WriteLine("Merhaba Lütfen yapmak istediginiz islemi seciniz..");
            Console.WriteLine("1.Lira Yükleme");
            Console.WriteLine("2.İnternet Paketi");
            Console.WriteLine("3.Konuşma Paketi");
            int secim = Convert.ToInt32(Console.ReadLine());
             switch(secim)
            {
                case 1:
                    Console.WriteLine("Lira Yükleme servisine Hoş Geldiniz");
                    break;
                case 2:
                    Console.WriteLine("İnternet Paketi servisine Hoş Geldiniz");
                    break;
                case 3:
                    Console.WriteLine("Konuşma Paketi servisine Hoş Geldiniz");
                    break;
                default:
                    Console.WriteLine("Müşteri Temsilcisine Yönlendiriliyorsunuz...");
                    break;
              }
            Console.ReadKey();
                    
 #endregion


            
           
        }
    }
}
