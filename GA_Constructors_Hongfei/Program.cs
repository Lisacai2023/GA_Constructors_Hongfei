using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_Hongfei
{
    //Week2-Constructors
    //01/14/2024
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Exporing Constructors in C# ");

            //Create the an instance with constructor
            Student s1 = new Student("Sam",1001, 1);
            Student s2 = new Student("Ethan",1002);
            Student s3 = new Student("Tian", 1003);
            Console.WriteLine("The studen is " + (s1.Name) + ", ID is " + (s1.StudentID) + ", grade is " + ( s1.Grade));
            Console.WriteLine("The studen is " + (s2.Name) + ", ID is " + (s2.StudentID) + ", grade is " + (s2.Grade));
            Console.WriteLine("The studen is " + (s3.Name) + ", ID is " + (s3.StudentID) + ", grade is " + (s3.Grade));

            Console.ReadKey();

            

        }
    }
}
