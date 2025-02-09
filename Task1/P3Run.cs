using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task1;

/// <summary>
/// The class with the implementation of the task 1 solution.
/// </summary>
public class Run
{
    /// <summary>
    /// To demonstrate the results of Task 1, this method calls helper methods that generate all exceptions declared in the array and one additional exception.
    /// </summary>
    public static void CallExceptions()
    {
        try
        {
            Console.WriteLine("\n---------------------- Task 1 -----------------------");
            HelperMethods.MethodWithDivideByZeroException();
            HelperMethods.MethodWithArgumentException();
            HelperMethods.MethodWithIndexOutOfRangeException();
            HelperMethods.MethodWithFormatException();
            HelperMethods.MethodWithHomeworkException();
            HelperMethods.MethodWithArgumentNullException();
        }
        finally
        {
            Console.WriteLine("\n------------- Task 1 has been completed -------------");
        }
    }

    /// <summary>
    /// A method to call the mentor iterator, created after checking the homework.
    /// </summary>
    public static void CallMentorIterator()
    {
        try
        {
            Console.WriteLine("\n---------------------- Task 1 -----------------------");
            ExceptionHandler.MentorIterator(SelectedExceptions.exceptionArray);
        }
        finally
        {
            Console.WriteLine("\n------------- Task 1 has been completed -------------");
        }
    }
}
