using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.AddRange(new int[] { 2, 3, 4 });

            //Console.WriteLine(numbers.Count);
            //Console.Clear();

            //foreach (var item in numbers)

            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i <numbers.Count; i++)
            //{
            //    Console.WriteLine("{0}={1}",i,numbers[i]);
            //}




            //int[] array = new int[2];
            //array[0] = 3;
            //array[1] = 5;
            //List<int> list = new List<int>(array);
            //Console.WriteLine("{0} tane eleman yazdıracağım.", list.Count);
            //foreach (var eleman in list)
            //{
            //    Console.Write(eleman + " ");

            //}
            //Console.ReadKey();


            //List<int> number = new List<int>(new int[] { 1903, 1904, 1905, 1997 });
            //int index = number.IndexOf(1997);


            //List<string> isimler = new List<string>();
            //isimler.AddRange(new string[] { "Ali", "Ayşe", "Fatma", "Veli", "Hayriye" });
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });
            //numbers.RemoveAt(0);//girilen index silinir.
            // numbers.Remove(3);//girilen değer silinir.o değerden birden fazla varsa ilkini siler.
            //numbers.RemoveRange(3,2);//aralık siler

            // bool varmi = numbers.Contains(13);
            //bool varmi = true;
            //while (varmi)
            //{
            //    if (numbers.Contains(8))
            //    {
            //        numbers.Remove(8);
            //    }
            //    else
            //    {
            //        varmi = false;
            //    }

            //}


            //var result = numbers.Find(i => i > 5);// 5 den büyük ilk değer döner.
            //Console.WriteLine(result);


            //var result = numbers.FindAll(i => i > 5);//5 den büyük bütün değerler döner.
            //var result = numbers.FindAll(i => i > 5).Count();//5 fden büyük kaç tane eleman varsa onu döndürür.
            //Console.WriteLine(result);
            numbers.Sort();//küçükten büyüğe sıralar
            numbers.Reverse();//büyükten küçüğe sıralar ama ilk sort kullanmak gerekiyor.
            foreach (var item in numbers)
            {
                Console.Write("\n\t" + item);
            }
            Console.ReadKey();
        }
    }
}
