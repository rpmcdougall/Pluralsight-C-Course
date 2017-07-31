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

            GradeBook book = new GradeBook();

            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.NameChanged += new NameChangedDelegate(OnNameChanged2);

            book.Name = "Ryan's Grade Book";
            book.Name = "Some other book";
            //made event, wont allow null to interfere with other delegates

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: " + (int)stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);

            WriteResult("Blah", stats.LowestGrade);
           
        }

        static void OnNameChanged(string existingName,string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }

        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
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
