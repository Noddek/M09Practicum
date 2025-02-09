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

    /// <summary>
    /// This is my iterator before checking my homework.
    /// </summary>
    /// <param name="caughtException">Exception</param>
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

    /// <summary>
    /// This is an iterator created after checking the homework based on the mentor's recommendations
    /// </summary>
    /// <param name="exceptionArray">Exception array</param>
    public static void MentorIterator(Exception[] exceptionArray)
    {
        Console.WriteLine("\nThis is exception handling based on the mentor iterator.\n");

        // Mentor said that I should have handled exceptions from the array in this way:
        // I have to put the exception handling in the foreach loop and manage exceptions
        // in the loop itself, manually throwing exceptions via 'throw' at each iteration.
        foreach (Exception arrayException in exceptionArray)
        {
            try
            {
                throw arrayException;
            }
            catch (HomeworkException)
            {
                Console.WriteLine($"\nThe {arrayException.GetType().Name} exception from the array has been caught.\n" +
                        $"\t{arrayException.Message}\n" +
                        $"\t{arrayException.HelpLink}");
                foreach (DictionaryEntry de in arrayException.Data)
                {
                    Console.WriteLine($"\t{de.Key.ToString()} {de.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nThe {arrayException.GetType().Name} exception from the array has been caught.\n" +
                        $"\t{ex.Message}");
            }
        }

        // Generating a non-array exception separately, for the test:
        try
        {
            int? a = null;
            int b = 1;
            int c = (int)a + b;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nA new exception is caught in MentorIterator() method, not from the array: {ex.GetType().Name}.\n\tDefault system message: \"{ex.Message}\"");
        }
    }
}
