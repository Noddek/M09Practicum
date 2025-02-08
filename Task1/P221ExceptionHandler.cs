using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task1;

/// <summary>
/// The class for exception handling logic.
/// </summary>
public class ExceptionHandler
{
    // Task:
    // 2.2. Implement a TryCatchFinally statement that iterates for each type of the exception array (finally block is optional).

    // Solution:
    // 2.2.1. First, let's create a method with which we will iterate through the types of exceptions.

    // Task:
    // 3. In the 'catch' block, display the exception message in the console.

    public static void Iterator(Exception caughtException)
    {
        // It's the switcher to display the exception message only once:
        int switcher = 0;

        // This is the main part of the iterator, it works with the array of selected exceptions:
        foreach (Exception arrayException in SelectedExceptions.exceptionArray)
        {
            if (caughtException.GetType() == arrayException.GetType())
            {
                if (caughtException.GetType() == typeof(HomeworkException))
                {
                    Console.WriteLine($"\tThe exception from the array has been caught.\n" +
                        $"\t{arrayException.Message}\n" +
                        $"\tMessage from the source of the exception:\n" +
                        $"\t\t{caughtException.Message}\n" +
                        $"\t\t{caughtException.HelpLink}");
                    foreach (DictionaryEntry de in caughtException.Data)
                    {
                        Console.WriteLine($"\t\t{de.Key.ToString()} {de.Value}");
                    }
                }
                else
                {
                    Console.WriteLine($"\tThe exception from the array has been caught.\n" +
                        $"\t{arrayException.Message}\n" +
                        $"\tMessage from the source of the exception:\n" +
                        $"\t\t{caughtException.Message}");
                }
                switcher = 1;
                break;
            }
        }

        // This is the handling of the rest of the exceptions:
        if (switcher == 0)
        {
            Console.WriteLine($"\tA new exception is caught, not from the array. Default system message: \"{caughtException.Message}\"");
        }
    }
}
