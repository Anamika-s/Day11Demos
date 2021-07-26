using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Demos
{
    class LinqMethodSyntaxDemo
    {
        static void Main()
        { 
        List<Student> students = new List<Student>()
            {
                new Student() {Id =1, Name ="Ajay" , Batch = "B001", Marks=90},

                new Student() {Id =2, Name ="Abhijit" , Batch = "B001", Marks=80},

                new Student() {Id =3, Name ="Sneha" , Batch = "B002", Marks=93},

                new Student() {Id =4, Name ="Meenu" , Batch = "B002", Marks=87},

                new Student() {Id =5, Name ="Deepak" , Batch = "B003", Marks=91},

                new Student() {Id =6, Name ="Bhagya" , Batch = "B003", Marks=88},
            };

            var list = students.ToList();

            foreach (var temp in list)
                Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Batch + " " + temp.Marks); ;

            Console.WriteLine("Marks in between 80 && 90");
            list = students.Where(x => x.Marks > 80 && x.Marks < 90).ToList();

            foreach (var temp in list)
                Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Batch + " " + temp.Marks); ;

            Console.WriteLine("Enter Name to Search");
            string name = Console.ReadLine();

            //var student = (from temp in students
            //               where temp.Name == name
            //               select temp).First();
            //Console.WriteLine("Name is " + student.Name);

            var student = students.Where(x => x.Name == name).FirstOrDefault();
           // var student = students.FirstOrDefault(x => x.Name == name);
            if (student!=null)
            Console.WriteLine("Name is " + student.Name);
            else
                Console.WriteLine("Ths student with this name {0} does not exist", name);
        }
}
}
