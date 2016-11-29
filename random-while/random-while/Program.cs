using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_while
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tahmin

         
            Console.WriteLine("[1-10] arasında bir sayi tuttum hadi bul bakalım= ");
            Random rnd = new Random();
            int rastgelesayi = rnd.Next(1, 11);
            int tahmin, counter = 0; 
            while (true)
            {
                counter++;
                Console.Write("Tahmin Ne =");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if(tahmin==rastgelesayi)
                { 
                    break;
                }
                
            }
            Console.WriteLine("\nTebrikler....{0}. adımda bildin", counter);
            Console.ReadKey();
   #endregion

        }
    }
}
