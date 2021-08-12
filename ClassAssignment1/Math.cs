using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    public class Math
    {
        public static void div1(int num1)
        {
            int result1 = num1 / 2;
            Console.WriteLine(num1 + " divided by 2 equals " + result1);
        }

        //example of overloaded method (same name as above but with more parameters)
        public static void div1(int num1, int num2)
        {
            int result1 = num1 / num2;
            Console.WriteLine(num1 + " divided by " + num2 + " equals " + result1);
        }

        //example method that returns outputs 
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Please enter a value for \"a\": ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a value for \"b\": ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        

    }
    //example of static class
    public static class msg
    {
        public static void goodbyeMessage()
        {
            Console.WriteLine("End of program, goodbye!");
            Console.ReadLine();
        }
    }
}
