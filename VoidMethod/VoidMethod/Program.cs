using System;

namespace VoidMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math add1 = new Math();
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered " + num1 + ". Please enter a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number is " + num2 + ". Adding numbers together...");
            //passing in user input integer variables
            Math.add1(num1, num2);
            Console.WriteLine("Doing more math...");
            //passing in integers as plain integers
            Math.add1(15, 25);
            //passing in integer variables by name
            Math.add1(num1 = 20, num2 = 50);
        }
    }
}
