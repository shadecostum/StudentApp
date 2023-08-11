using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Student studPerson=new Student(12,"akash",5);
            Console.WriteLine(studPerson.ResultDetails());
            Console.WriteLine("------------------------------------");
            Student studPerson2 = new Student(-5, "aka", 45);
            Console.WriteLine(studPerson2.ResultDetails());
            Console.WriteLine("------------------------------------");
            Student studPerson3 = new Student(8, "aka", 45);
            Console.WriteLine(studPerson3.ResultDetails());
            Console.WriteLine("------------------------------------");
            Student studPerson4 = new Student(2, "akash", 45);
            Console.WriteLine(studPerson4.ResultDetails());
            Console.WriteLine("------------------------------------");
            Student studPerson5 = new Student(3, "akash", 8);
            Console.WriteLine(studPerson5.ResultDetails());
            Console.WriteLine("------------------------------------");
        }
    }
}
