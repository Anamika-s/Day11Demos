using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Demos
{
    class LinqDemo2
    {
        static void Main()
        {
            string[] names = new string[] { "ABCDEFGHIJKLM" ,"Deepak", "Ajay", "Sneha", "Bhagya", "Franklin" };
            var list = (from temp in names
                        where temp.Length < 10
                        select temp);

            foreach(var temp in list)
                Console.WriteLine(temp);

            Console.WriteLine("Name contains k");
              list = (from temp in names
                        where temp.Contains("k") || temp.Contains("a")
                        select temp);

            foreach (var temp in list)
                Console.WriteLine(temp);

            Console.WriteLine("Name contains k");
            list = (from temp in names
                    where temp.StartsWith("a")
                    select temp);

            foreach (var temp in list)
                Console.WriteLine(temp);
        }
    }
}
