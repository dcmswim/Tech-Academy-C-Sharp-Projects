using System;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {   //intro console output
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //converts user input to integer variable
            Console.WriteLine("Please enter package weight. (round to the nearest pound)");
            int weight = Convert.ToInt32(Console.ReadLine());
            //exits program is user input is > 50
            if (weight > 50)
            {
                Console.WriteLine("Sorry, package is too heavy to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Please enter package width. (round to the nearest inch)");
            }
            //gets user input for package dimensions and converts to integer variable
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height (round to the nearest inch)");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package length. (round to nearest inch)");
            int length = Convert.ToInt32(Console.ReadLine());
            //exits if sum of last 3 inputs is > 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Sorry, package is too large to be shipped.");
            }
            else
            {   //calculates shipping cost using previous inputs
                decimal quote = ((width * height * length) * weight) / 100;
                Console.WriteLine("Shipping cost for this package is $" + quote);
                Console.ReadLine();
            }
            


        }
    }
}
