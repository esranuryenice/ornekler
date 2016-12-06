using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_boyutlu_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sinavlar = new int[2, 3];
            sinavlar[0, 0] = 1;
            sinavlar[1, 0] = 20;
            sinavlar[0, 1] = 2;
            sinavlar[1, 1] = 40;
            sinavlar[0, 2] = 3;
            sinavlar[1, 2]= 60;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sinavlar[0,i]+ " - " + sinavlar[1,i]);
            }
            Console.ReadKey();

        }
    }
}
