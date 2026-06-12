using System;
using System.Collections.Generic;
using System.Text;

// Created this class just to demonstrate the usage of the "using" directive when used globally
// Using a method from the globally-declared System.Diagnostics namespace in StringsTextualRepository.cs
static class Global_Using_Example
{
    public static void usingSystemDiagnosticsExampleMethod()
    {
        var stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine($"The value of i is {i}");
        }

        stopwatch.Stop();
        Console.WriteLine($"The whole for loop took {stopwatch.ElapsedMilliseconds} milliseconds.\n");
    }
}