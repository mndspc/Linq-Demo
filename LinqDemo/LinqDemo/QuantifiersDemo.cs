using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class QuantifiersDemo
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){StudentID=1,StudentName="Scott",Age=18 },
                new Student(){StudentID=2,StudentName="Tiger",Age=15 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }

            };

            bool areAllStudentTeenAger = studentList.All(x => x.Age > 12 && x.Age < 20);
            bool isAnyStudentTeenAger = studentList.Any(x => x.Age > 12 && x.Age < 20);
            Console.WriteLine(areAllStudentTeenAger);
            Console.WriteLine(isAnyStudentTeenAger);
            Console.ReadLine();
        }
    }
}
