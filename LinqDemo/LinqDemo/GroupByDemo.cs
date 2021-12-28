using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class GroupByDemo
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };

            var groupedResult = studentList.GroupBy(x => x.Age);

            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine($"Age Group:{ageGroup.Key}");
                foreach (var std in ageGroup)
                {
                    Console.WriteLine($"\t\tID={std.StudentID} Name={std.StudentName}");
                }
            }
            Console.ReadLine();
        }
    }
}
