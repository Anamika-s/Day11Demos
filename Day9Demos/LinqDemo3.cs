using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Demos
{
    class LinqDemo3
    {
        static void Main()
        {
            List<string> names = new List<string>()
           { "ABCDEFGHIJKLM" ,"Deepak", "Ajay", "Sneha", "Bhagya", "Franklin" };

            var list = (from temp in names
                        select temp);



        }
    }
}