using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            #region fortanım


            /* for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine("esra");
             }
             Console.ReadKey();*/
            #endregion

            #region while-for_arasindaki farklar
            /* int n = 5, fakto = 1;
             for (int i = 1; i <= n; i++)
             {
                 fakto = fakto * i;
             }
             Console.WriteLine(fakto);
             Console.ReadKey();*/
            #endregion

            #region birdenfazlakontrol
            /* bool durum = true;
             for (int i = 0; durum==true && i < 100; i++)
             {
                 if (i * 2 > 20)
                 {
                     durum = false;
                 }
                 else
                 {
                     Console.WriteLine("{0} iken devam ediyorum",i);
                 }
             }
             Console.ReadKey();*/
            #endregion

            #region breakContinue
            /*for (int i = 0; i < 100; i++)
            {
                if (i * 2 < 20)
                {
                    //break;//döngüyü sonlandırır.
                    continue;//bir sonraki değere geçirir
                    
                }
                Console.WriteLine("{0} iken devam ediyorum",i);
            }
            Console.ReadKey();*/

            #endregion

            #region [1,n]aralıgindakisayilarintoplami

            /* Console.Write("Sayıyı Gir : ");
             int n = Convert.ToInt32(Console.ReadLine());
             int toplam = 0;

             for (int i = 1; i <= n; i++)
             {
                 toplam = toplam+  i;
                 Console.WriteLine("i : {0} \t Toplam : {1}",i,toplam);
             }
             Console.WriteLine("Sonuç = " + toplam );
             Console.ReadKey();*/

            #endregion

            #region icicefor
            /* for (int i = 0; i < 10; i++)
             {
                 for (int j = 0;j < 5; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             Console.ReadKey();*/


            #endregion

            #region harfler
            /* for (char i = 'a'; i <= 'z'; i++)
             {
                 Console.Write(i + " ");
             }
             Console.ReadKey();*/
            #endregion


            #region carpımtablosu

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1}\t= {2}", i , j, i*j );
                }
                Console.WriteLine("------------");
            }
            Console.ReadKey();

            #endregion
        }
    }
}
