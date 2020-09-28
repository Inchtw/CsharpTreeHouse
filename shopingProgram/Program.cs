using System;
using System.Threading;

namespace shopingProgram
{
    class Program
    {
        static string Ask(string question) //static keyword means you can call the method all by itself; it doesn't belong to an object.
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }
        static void EscapeSequence()
        {
            Console.WriteLine("first line\nsecond line");
            Console.WriteLine("\tnew paragraph");
            Console.WriteLine("He said, \"Whoa.\"");
            Console.WriteLine("A backslash: \\");
        }
        static void StringInterpolation(int number)
        {
            Console.WriteLine($"{number} aca");

        }
        static void StringInterpolation(string words)
        {
            Console.WriteLine($"{words} aca");

        }
        static void Sleep()
        {
            Console.WriteLine("I'm going to Sleep!");
            // System.Threading.Thread.Sleep(1000); //The problem is that System.Threading is a separate namespace from System. So we can't just remove System from the front of the method name.
            Thread.Sleep(1000); // using System.Threading;
            Console.WriteLine("done Sleeping!");
        }
        static double Price(int quantity)
        {
            double pricePerUnit;
            if (quantity >= 100)
            {
                pricePerUnit = 1.5;
            }
            else if (quantity >= 50)
            {
                pricePerUnit = 1.75;
            }
            else
            {
                pricePerUnit = 2;
            }

            return quantity * pricePerUnit; // int -> double less to accurate is ok
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the shoping!");
            string ans = Ask("How mant cans are you ordering?");
            Console.WriteLine($"You want to order {ans} cans.");
            int number = int.Parse(ans);
            double total = Price(number);
            Console.WriteLine($"For {number} cans, your total is : ${total}");

        }
    }
}
