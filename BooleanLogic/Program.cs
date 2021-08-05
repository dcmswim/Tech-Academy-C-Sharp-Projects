using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro console message
            Console.WriteLine("Please input your age.");
            //stores user input as integer variable
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHave you ever had a DUI? Please enter true or false.");
            //stores user response as boolean variable (true or false required)
            bool checkDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nHow many speeding tickets do you have?");
            //converts user input to integer variable
            int tickets = Convert.ToInt32(Console.ReadLine());
            //checks conditions based on previous user input
            //all requirements must be satisfied to return true
            bool qualify = age > 15 && checkDui == false && tickets <= 3;
            Console.WriteLine("Do you qualify for insurance? Let's check... " + qualify);
            //leaves final console response on screen until program is manually closed
            Console.ReadLine();
        }
    }
}
