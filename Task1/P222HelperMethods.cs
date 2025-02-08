using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task1;

/// <summary>
/// The class with helper methods for solving the task.
/// </summary>
public class HelperMethods
{
    // Solution:
    // 2.2.2. Because we can't write multiple 'try' blocks, we need helper methods to generate all exceptions that we'll use in a single 'try' block.

    public static void MethodWithDivideByZeroException()
    {
        try
        {
            Console.WriteLine($"\n{new StackTrace(false).GetFrame(0).GetMethod().Name}:");
            int a = 1;
            int b = 0;
            Console.WriteLine(a / b);
        }
        catch (Exception ex)
        {
            ExceptionHandler.Iterator(ex);
        }
    }

    public static void MethodWithArgumentException()
    {
        Console.WriteLine($"\n{new StackTrace(false).GetFrame(0).GetMethod().Name}:");
        try
        {
            throw new ArgumentException("The exception is thrown manually specifically for the test.");
        }
        catch (Exception ex)
        {
            ExceptionHandler.Iterator(ex);
        }
    }

    public static void MethodWithIndexOutOfRangeException()
    {
        Console.WriteLine($"\n{new StackTrace(false).GetFrame(0).GetMethod().Name}:");
        try
        {
            int[] numbers = { 1, 2, 3 };
            numbers[4] = 4;
        }
        catch (Exception ex)
        {
            ExceptionHandler.Iterator(ex);
        }
    }

    public static void MethodWithFormatException()
    {
        Console.WriteLine($"\n{new StackTrace(false).GetFrame(0).GetMethod().Name}:");
        try
        {
            decimal price = 169.32m;
            Console.WriteLine("The cost is {0:Q2}.", price);
        }
        catch (Exception ex)
        {
            ExceptionHandler.Iterator(ex);
        }
    }

    public static void MethodWithHomeworkException()
    {
        Console.WriteLine($"\n{new StackTrace(false).GetFrame(0).GetMethod().Name}:");
        try
        {
            throw new HomeworkException("An error has been found in the homework.");
        }
        catch (Exception ex)
        {
            ExceptionHandler.Iterator(ex);
        }
    }

    public static void MethodWithArgumentNullException()
    {
        Console.WriteLine($"\n{new StackTrace(false).GetFrame(0).GetMethod().Name}:");
        try
        {
            int? a = null;
            int b = 1;
            int c = (int)a + b;
        }
        catch (Exception ex)
        {
            ExceptionHandler.Iterator(ex);
        }
    }
}
