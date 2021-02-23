using System; //using statement for namespace
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.ShowStatistics();
        }
    }
} 
