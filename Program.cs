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
            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();

            Console.WriteLine("It is very nice to meet you " + userName);


        }
    }
}
