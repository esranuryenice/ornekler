using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case2
{
    class Program
    {
        static void Main(string[] args)
        {   bas:
            Console.Write("1. sayiyi girin=" + " ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayiyi girin=" + " ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlemi Girin="+ " ");
            char islem = Convert.ToChar(Console.ReadLine());
            switch (islem)
            {
                case '+':
                    Console.Write("Sayilarin Toplami= "+" " + (sayi1 + sayi2));
                    break;
                case '-':
                    Console.Write("Sayilarin Cikartmasi=" + "  "  + (sayi1 - sayi2));
                    break;
                case '*':
                    Console.Write("Sayilarin Carpımı=" + " " + (sayi1 * sayi2));
                    break;
                case '/':
                    Console.Write("Sayilarin Bolümü=" + " " + (sayi1 / sayi2));
                    break;
                default:
                    Console.WriteLine("\nYanlis Bir Secim Yaptınız \nLütfen Yeniden Secim Yapın\n");
                    goto bas;
                    

            }
            Console.ReadKey();




        }
    }
}
