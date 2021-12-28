using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class AggregateDemo
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                 new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Mathew", Age = 15 }
        };


            var totalStudents = studentList.Count();
            Console.WriteLine($"Count is {totalStudents}");

            var adultStudents = studentList.Count(s => s.Age > 18);
            var maxAge = studentList.Max(s => s.Age);
            var minAge = studentList.Min(s => s.Age);
            var AvgAge = studentList.Average(s => s.Age);

            Console.WriteLine($"Count of adult student is:{adultStudents} Max:{maxAge} Min:{minAge} Average:{AvgAge}");

            Console.ReadLine();
        }
    }
}
