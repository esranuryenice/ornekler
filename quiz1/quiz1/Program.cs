using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.Write("Sayiyi Girin = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {

                toplam = toplam + i;
            }
            Console.WriteLine("Sayıların toplamı= " + toplam);
               
                for (int j = 10; j >= 1; j--)
                {

                    Console.WriteLine(j);

                }
            
            Console.ReadKey();
        }
    }
}
