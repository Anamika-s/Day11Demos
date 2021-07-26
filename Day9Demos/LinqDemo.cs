using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Demos
{
    class LinqDemo
    {
        static void Main()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Min no
            var min = (from temp in num
                       select temp).Min();

            // Sum of Elements
          
            var sum = (from temp in num
                       select temp).Sum();
           
            // Average 

            var avg = (from temp in num
                       select temp).Average();

            // Sum of Even Elements

              sum = (from temp in num
                       where temp%2==0
                       select temp).Sum();

        }
    }
}
