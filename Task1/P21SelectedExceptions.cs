using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task1;

/// <summary>
/// The class with array of 5 selected exception types (type instances).
/// </summary>
public class SelectedExceptions
{
    // Task:
    // 2.1. Create an array of 5 different types of exceptions, including your own exception type.

    // Solution:
    // Honestly, I didn't understand the point of creating this array. So I defined specific messages to make some sense for iterator and test.

    /// <summary>
    /// Array of 5 selected exception types (type instances).
    /// </summary>
    public static Exception[] exceptionArray =
    {
        new DivideByZeroException("Message of array exception: \"5th place in frequency of occurrence.\""),
        new ArgumentException("Message of array exception: \"3rd place in frequency of occurrence.\""),
        new IndexOutOfRangeException("Message of array exception: \"4th place in frequency of occurrence.\""),
        new FormatException("Message of array exception: \"2nd place in frequency of occurrence.\""),
        new HomeworkException("Message of array exception: \"1st place in frequency of occurrence.\"")
    };
}
