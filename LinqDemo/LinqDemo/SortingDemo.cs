using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class SortingDemo
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
        };

            var orderByAscResult = studentList.OrderBy(x => x.StudentName);
            foreach (var std in orderByAscResult)
            {
                Console.WriteLine($"ID={std.StudentID} Name={std.StudentName} Age={std.Age}");
            }

            Console.WriteLine("***********Order By Desc****************************");
            var orderByDescResult = studentList.OrderByDescending(x=>x.StudentName);
            foreach (var std in orderByDescResult)
            {
                Console.WriteLine($"ID={std.StudentID} Name={std.StudentName} Age={std.Age}");
            }
            Console.ReadLine();
        }

    }
}
