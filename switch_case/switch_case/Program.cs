using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("carsamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("pazar");
            //        break;
            //    default:
            //        Console.WriteLine("yanlış Giriş!");
            //        break;
            //}
            //Console.ReadKey();

            baş:
            int gun = Convert.ToInt32(Console.ReadLine());
            switch (gun)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;

            }
            if (gun > 0)
            {
                goto baş;
            }

        }
    }
}
