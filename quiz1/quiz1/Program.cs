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
            for (int i = 1; i < 10; i++)
            {
                toplam = toplam + i;

               // for (int j = 1; j <=10 ; j--)
               // {
               //     Console.WriteLine(j);
               // }
                Console.WriteLine("Toplam = " + i);
                
            }
            Console.ReadKey();


        }
    }
}
