using System;

namespace DotNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declare variables and print their values
            // Here I create variables for name, age, and admin status, then print them to the console.
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Is Admin: " + isAdmin);

            // Task 2: Check if the number is even or odd
            // I prompt the user to enter a number and check if it's even or odd using simple logic.
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            // Task 3: Print numbers 1 to 10 using a for loop
            // This loop prints numbers from 1 to 10, one by one.
            Console.WriteLine("Numbers 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Task 4: Sum up the elements of an array and print each one
            // First, I initialize an array with a few values, then use a foreach loop to print each item and sum them.
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
                Console.WriteLine("Element: " + num);
            }
            Console.WriteLine("Sum of elements: " + sum);

            // Task 5: Greet method that prints a personalized message
            // I created a simple method that accepts a name and prints a greeting message.
            Greet("Alice");
        }

        // Task 5: Greet method
        // This method takes a name and greets the person by printing a custom message.
        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
