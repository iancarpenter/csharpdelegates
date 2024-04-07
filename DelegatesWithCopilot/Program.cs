﻿// See https://aka.ms/new-console-template for more information
// 1. Create a hello world program in C# demostrating how deletegates work
// 2. ensure that the code is commented
// 3. Ensure that the code is well formatted
// 4. Ensure that the code is easy to test

using System;

namespace DelegatesWithCopilot
{
    // Delegate is a type that represents references to methods with a particular parameter list and return type.
    // When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
    // You can invoke (or call) the method through the delegate instance.
    public delegate void Print(int value);

    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the delegate
            Print printDel = PrintNumber;

            // Call the delegate
            printDel(100000);
            printDel(200);

            // Instantiate the delegate with a different method
            printDel = PrintMoney;

            // Call the delegate
            printDel(10000);
            printDel(200);
        }

        // Method that takes an integer and prints to the console
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0}", num);
        }

        // Method that takes an integer and prints to the console as currency
        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}