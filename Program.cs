using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            var numberOfCupsOfCoffee = 1;
            var fullName = "Amanda Joy Wade";
            var today = DateTime.Now;
            Console.WriteLine($"My name is {fullName} and I have had {numberOfCupsOfCoffee} cup of coffee on {today}");

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            if (userName == "Alice")
            {
                Console.WriteLine("Welcome to Wonderland, Alice!");
            }
            else
            {
                Console.WriteLine("It is very nice to meet you " + userName);
            }

            Console.Write("Need help with Math Homework? Please give two numbers. ");

            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);


            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine("These two numbers added together equals " + sum);
            Console.WriteLine("The second number subtracted from the first number equals " + difference);
            Console.WriteLine("These two numbers multiplied together equals " + product);
            Console.WriteLine("The first number divided by the second number equals " + quotient);
            Console.WriteLine("The remainder left over when you divide the first number by the second number equals " + remainder);
        }
    }
}
