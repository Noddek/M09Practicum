using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task2;

// Task:
// 2. Sorting must be done using an event.
// Sorting should be performed when user enters 1 (sort A-Z) or 2 (sort Z-A).
// It's necessary to implement the check of the entered data through the TryCatchFinally construct using our own exception type.

// Solution:
// 2.1. First, create our own exception type.
// After checking homework:
// 2.1.1. The mentor suggested to read this: https://learn.microsoft.com/ru-ru/dotnet/standard/exceptions/how-to-create-localized-exception-messages

/// <summary>
/// My type of exception for Task 2 of homework.
/// </summary>
public class KeyboardInputException : Exception
{
    public KeyboardInputException() { }
    public KeyboardInputException(string message) : base(message) { }

    // Addendum to solution, per the mentor's advice:
    
    // 2.1.1.1. Adding a property:
    public string EnteredString { get; }
    
    // 2.1.1.2. Adding more constructors:
    public KeyboardInputException(string message, Exception inner) : base(message, inner) { }
    public KeyboardInputException(string message, string enteredString) : this(message) { EnteredString = enteredString; }

}
