
using System;
using System.Linq;
namespace Day9Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int max = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] > max)

            //        max = num[i];
            //    Console.WriteLine(num[i]);
            //}

            //foreach (int x in num)
            //{
            //    if (x % 2 == 0)
            //        Console.WriteLine(x);
            //}
            // Qyuery Syntax
            var list = (from temp in num
                        where temp%2==0
                        select temp);

            foreach(int x in list)
                Console.WriteLine(x);
            // Qyuery Syntax
            var max = (from temp in num
                       select temp).Max();

            Console.WriteLine("Max no is " + max);

        }
    }
}
