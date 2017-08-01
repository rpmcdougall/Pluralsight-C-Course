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


            Console.WriteLine("Enter a name: ");

            try
            {
                book.Name = Console.ReadLine();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Kaboom!");

            }
            catch(Exception)
            {
                Console.WriteLine("Error: no error");
            }
            // book.Name = null;



            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
        
            WriteResult("Average Grade: " , stats.AverageGrade);
            WriteResult("Highest Grade: " , stats.HighestGrade);
            WriteResult("Lowest Grade: " , stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
            
           
        }


        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);

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
