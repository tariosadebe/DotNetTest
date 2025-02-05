using System;

namespace DotNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Is Admin: " + isAdmin);

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

            Console.WriteLine("Numbers 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
                Console.WriteLine("Element: " + num);
            }
            Console.WriteLine("Sum of elements: " + sum);

            Greet("Alice");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
