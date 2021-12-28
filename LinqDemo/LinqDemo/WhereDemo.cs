using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class WhereDemo
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){StudentID=1,StudentName="Scott",Age=13 },
                new Student(){StudentID=2,StudentName="Tiger",Age=21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }

            };

            var adultStudents = studentList.Where(x => x.Age > 20);
            foreach(var std in adultStudents)
            {
                Console.WriteLine($"ID={std.StudentID} Name={std.StudentName} Age={std.Age}");
            }

            Console.ReadLine();
        }
    }
}
