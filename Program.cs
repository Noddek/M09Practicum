﻿namespace M09Practicum;

internal class Program
{
    static void Main(string[] args)
    {
        // Task 1:
        Task1.Run.CallExceptions();
        Task1.Run.CallMentorIterator();

        // Task 2:
        Task2.EventSubscriber.RunSurnameSorting();

        Console.ReadKey();
    }
}
