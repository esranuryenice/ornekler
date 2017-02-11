using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<char> karakterler = new List<char>();
            //for (char i = 'a'; i <='z'; i++)
            //{
            //   karakterler.Add(i);

            //}

            //karakterler.Reverse();
            //foreach (var item in karakterler)
            //{
            //    Console.Write(item + " ");
            //}
            //for (int i = 0; i < karakterler.Count; i++)
            //{
            //    Console.Write(karakterler[i]+ " ");
            //}
            //Console.ReadKey();


            List<string> isimler = new List<string>();

            isimler.Add("Hakan");
            isimler.AddRange(new string[] { "Esra", "Enes", "Aytekin", "Cemal", "Burcu" });

            isimler.Sort();
            //isimler.Reverse();
            foreach (var item in isimler)
            {
                Console.WriteLine("\t"+item);
            }
            Console.ReadKey();
        }
    }
}
