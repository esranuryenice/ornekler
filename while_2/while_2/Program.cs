using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayiyi Girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            

            int sayac = 1;
            int fakto = 1;
            while (sayac <= sayi2)
            {
                fakto = fakto * sayac;
                sayac++;
            }
            Console.WriteLine("sonuc2= " + fakto);
            Console.ReadKey();

        }
    }
    }
