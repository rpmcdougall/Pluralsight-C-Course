using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g2.Name = "Ryan's Compendium of Awesomeness";
            Console.WriteLine(g1.Name);



            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: " + (int)stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);

            WriteResult("Blah", stats.LowestGrade);
           
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);

        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result}");

        }
    }
}
