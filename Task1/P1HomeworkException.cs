using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task1;

// Task:
// 1. Create your own type of exception.

/// <summary>
/// My type of exception for Task 1 of homework.
/// </summary>
public class HomeworkException : Exception
{
    public HomeworkException() { }
    public HomeworkException(string message) : base(message)
    {
        Data.Add("Date (UTC+0):", DateTime.UtcNow);
        HelpLink = "Info: Please contact your mentor, mentor@mentor.com";
    }
}
