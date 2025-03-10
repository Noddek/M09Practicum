﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task2;

// Solution:
// 1.3. Creating a separate class for helper methods.

/// <summary>
/// Class for helper methods
/// </summary>
public class HelperMethods
{
    /// <summary>
    /// Method for displaying a string array
    /// </summary>
    /// <param name="stringArray">Array of strings to display on the screen</param>
    public static void DisplayStringArray(string[] stringArray)
    {
        foreach (string s in stringArray)
        {
            Console.WriteLine($"\t{s}");
        }
    }


    // Solution:
    // 2.2. Creating a method to dialog with the user that returns the entered number.

    /// <summary>
    /// Method for requesting the user to enter the number 1 or 2.
    /// </summary>
    /// <returns>Entered number: 1 or 2.</returns>
    public static byte RequestToEnterNumber1or2()
    {
        Console.WriteLine("\nPlease, enter the number to specify the sort order of the surname list: \n\t1 - sort in ascending order,\n\t2 - sort in descending order.");

        byte sortingOrder = 0;

        // The loop continues indefinitely until the correct number is entered:
        do
        {
            try
            {
                Console.Write("\n\t");
                sortingOrder = Convert.ToByte(Console.ReadLine());
                if (sortingOrder != 1 && sortingOrder != 2)
                {
                    // Solution, after checking homework:
                    // 2.1.1.3. Trying to use localized exception messages when throwing an exception:

                    // var resourceManager = new ResourceManager("M09Practicum.Resources.ExceptionMessages", Assembly.GetExecutingAssembly());
                    // throw new KeyboardInputException(resourceManager.GetString("KeyboardInputIsWrong"));

                    // I think I did everything like here:
                    // https://learn.microsoft.com/ru-ru/dotnet/standard/exceptions/how-to-create-localized-exception-messages
                    // but it doesn't work: it doesn't find 'M09Practicum.Resources.ExceptionMessages.resources'.
                    // I mean, for some reason, it's searching 
                    // 'M09Practicum.Resources.ExceptionMessages.resources'
                    // not the
                    // 'M09Practicum.Resources.ExceptionMessages.resx'

                    // So I left the old version:
                    throw new KeyboardInputException("Please enter 1 or 2 only.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t{ex.Message}");
            }
        }
        while (sortingOrder != 1 && sortingOrder != 2);

        return sortingOrder;
    }
}
