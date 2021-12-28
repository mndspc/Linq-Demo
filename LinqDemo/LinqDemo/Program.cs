using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ query using linq operators
            List<string> stringList = new List<string>()
            {
                "C# Tutorials","VB.Net Tutorials","Lean C++","MVC Tutorials"
            };

            var result = stringList.Where(x => x.Contains("Tutorials"));

            foreach(var str in result)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
