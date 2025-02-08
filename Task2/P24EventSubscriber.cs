using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task2;

// 2.4. Creating a class-subscriber, in which we sort surnames using
// the event about the fact that the user entered a number,
// indicating the sorting order.

/// <summary>
/// Class-subscriber - the classe that receives the event and uses it.
/// </summary>
public class EventSubscriber
{
    /// <summary>
    /// Method with the implementation of the task 2 solution.
    /// </summary>
    public static void RunSurnameSorting()
    {
        Console.WriteLine("\n\n\n---------------------- Task 2 -----------------------");
        Console.WriteLine("\nOriginal surname list:");
        HelperMethods.DisplayStringArray(Surnames.surnames);
        try
        {
            /// <summary>
            /// Method that handles the event
            /// </summary>
            void SortAndDisplayEventHandler(byte sortingOrder)
            {
                if (sortingOrder == 1)
                {
                    Console.WriteLine($"\nThe number {sortingOrder} is entered, so the surnames are sorted in ascending order:");
                }
                else if (sortingOrder == 2)
                {
                    Console.WriteLine($"\nThe number {sortingOrder} is entered, so the surnames are sorted in descending order:");
                }
                else
                {
                    throw new ArgumentException();
                }
                HelperMethods.DisplayStringArray(MySort.StringSorting(Surnames.surnames, sortingOrder));
            }

            EventPublisher eventForSort = new EventPublisher();
            eventForSort.NumberIsEntered += SortAndDisplayEventHandler;
            eventForSort.StartNumberRequest();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n\t{ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nOriginal surname list again:");
            HelperMethods.DisplayStringArray(Surnames.surnames);
            Console.WriteLine("\n------------- Task 2 has been completed -------------");
        }
    }
}
