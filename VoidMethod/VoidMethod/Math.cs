using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Math
    {
        public static void add1(int num1, int num2)
        {

            Console.WriteLine("Please enter a number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered " + num1 + ". Please enter a second number.");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number is " + num2 + ". Adding numbers together...");
            int result = num1 + num2;
            Console.WriteLine("The result is " + result);
            

        }
     }

}
