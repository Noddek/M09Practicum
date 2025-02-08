using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09Practicum.Task2;

// Solution:
// 1.2. Creating the logic for sorting string arrays

/// <summary>
/// Class for sorting logic
/// </summary>
public class MySort
{
    /// <summary>
    /// Method to determine if 2 strings should be swapped: ascending order, A-Z.
    /// </summary>
    static bool IsAscendingStringSwap(string a, string b)
    {
        for (int i = 0; i < (a.Length > b.Length ? b.Length : a.Length); ++i)
        {
            if (a.ToCharArray()[i] < b.ToCharArray()[i]) { return false; }
            if (a.ToCharArray()[i] > b.ToCharArray()[i]) { return true; }
        }
        return false;
    }

    /// <summary>
    /// Method to determine if 2 strings should be swapped: descending order, Z-A.
    /// </summary>
    static bool IsDescendingStringSwap(string a, string b)
    {
        for (int i = 0; i < (a.Length > b.Length ? b.Length : a.Length); ++i)
        {
            if (a.ToCharArray()[i] > b.ToCharArray()[i]) { return false; }
            if (a.ToCharArray()[i] < b.ToCharArray()[i]) { return true; }
        }
        return false;
    }

    /// <summary>
    /// Method for sorting string array
    /// </summary>
    /// <param name="originalStringArray">String array for sorting</param>
    /// <param name="sortingOrder">1 - ascending order, 2 - descending order</param>
    /// <returns>Sorted string array</returns>
    public static string[] StringSorting(string[] originalStringArray, byte sortingOrder)
    {
        string[] sortedStringArray = new string[originalStringArray.Length];
        Array.Copy(originalStringArray, sortedStringArray, sortedStringArray.Length);

        if (sortingOrder == 1)
        {
            for (int i = 0; i < sortedStringArray.Length; ++i)
            {
                for (int j = 0; j < sortedStringArray.Length - 1; ++j)
                {
                    if (IsAscendingStringSwap(sortedStringArray[j], sortedStringArray[j + 1]))
                    {
                        (sortedStringArray[j], sortedStringArray[j + 1]) = (sortedStringArray[j + 1], sortedStringArray[j]);
                    }
                }
            }
        }
        else if (sortingOrder == 2)
        {
            for (int i = 0; i < sortedStringArray.Length; ++i)
            {
                for (int j = 0; j < sortedStringArray.Length - 1; ++j)
                {
                    if (IsDescendingStringSwap(sortedStringArray[j], sortedStringArray[j + 1]))
                    {
                        (sortedStringArray[j], sortedStringArray[j + 1]) = (sortedStringArray[j + 1], sortedStringArray[j]);
                    }
                }
            }
        }
        else
        {
            throw new ArgumentException("An unacceptable sort order parameter is specified.");
        }

        return sortedStringArray;
    }
}
