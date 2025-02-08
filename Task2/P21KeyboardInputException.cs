using System;
using System.Collections.Generic;
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

/// <summary>
/// My type of exception for Task 2 of homework.
/// </summary>
public class KeyboardInputException : Exception
{
    public KeyboardInputException() { }
    public KeyboardInputException(string message) : base(message) { }
}
