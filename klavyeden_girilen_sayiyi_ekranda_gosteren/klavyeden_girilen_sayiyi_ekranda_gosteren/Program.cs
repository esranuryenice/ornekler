using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_girilen_sayiyi_ekranda_gosteren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birici Sayi: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sayi: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sayilarimiz : {0} , {1}", sayi1, sayi2);
            Console.WriteLine("Toplam : {0}", sayi1+sayi2);
            Console.WriteLine("Çarpım : {0}", sayi1 * sayi2);
            Console.WriteLine("Bölüm : {0}", sayi1 / sayi2);
            Console.WriteLine("Çıkarma : {0}", sayi1 - sayi2);
            Console.WriteLine("Mod : {0}", sayi1%sayi2);


            Console.ReadKey();
        }
    }
}
