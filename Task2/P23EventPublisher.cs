using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task2;

// Solution:
// 2.3. Creating an event publisher class, which will be used to generate the event.

/// <summary>
/// Event publisher class
/// </summary>
public class EventPublisher
{
    /// <summary>
    /// Event declared using the generic delegate 'Action'
    /// </summary>
    public event Action <byte>? NumberIsEntered;

    /// <summary>
    /// Method to call the event.
    /// </summary>
    protected virtual void OnNumberIsEntered(byte sortingOrder)
    {
        NumberIsEntered?.Invoke(sortingOrder);
    }

    /// <summary>
    /// Method that starts a request to enter a number from the keyboard to determine the sort order
    /// </summary>
    public void StartNumberRequest()
    {
        byte sortingOrder = HelperMethods.RequestToEnterNumber1or2();
        OnNumberIsEntered(sortingOrder);
    }
}
