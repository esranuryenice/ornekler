using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_cevaplari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region soru2cevap

            //int toplam = 0, n = 10;
            //for (int i = 1; i <= n; i++)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine("Sayıların toplamı "+ toplam);

            //Console.Write("Sayıların tersten yazılışı : ");
            //for (int j = 10; j >=1; j--)
            //{
            //    Console.Write(j+ " ");

            //}

            //Console.ReadKey();
            #endregion

            #region Soru3cevap

            Console.WriteLine("Şekil Seçiniz(kare-dikdörtgen-paralelkenar)");
            string secim = Convert.ToString(Console.ReadLine());
            if (secim == "kare")
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 0 || i == 4 || j == 0 || j == 4)
                        {
                            Console.Write("* ");

                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();

                }

            }



          else  if (secim == "dikdörtgen")
            {


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (i == 0 || i == 4 || j == 0 || j == 7)
                        {
                            Console.Write("* ");

                        }
                        else
                        {
                            Console.Write("  ");
                        }

                    }
                    Console.WriteLine();

                }


            }

          else  if (secim == "paralelkenar")
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (i == 0 && j >= 2|| i == 1 && (j == 1 || j == 4)|| i == 2 && j <= 3 )
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                     ////   if (i == 1 && (j == 1 || j == 4))
                     //   {
                     //       Console.Write("*");
                     //   }
                     //   else
                     //   {
                     //       Console.Write(" ");
                     //   }
                     //   if (i == 2 && j <=3)
                     //   {
                     //       Console.Write("*");
                     //   }
                     //   else
                     //   {
                     //       Console.Write(" ");
                     //   }
                    }
                    Console.WriteLine();
                }


            }

            else
            {
                Console.WriteLine("yanlış seçim yaptınız!");
               
            }




            Console.ReadKey();

        }





        #endregion




    }
}

