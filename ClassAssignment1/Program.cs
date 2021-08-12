using System;

namespace ClassAssignment1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Math div1 = new Math();
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Math.div1(num1);

            //example of calling overloaded function
            Console.WriteLine("Please enter a new number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Math.div1(num1, num2);

            // Output parameters example
            Math n = new Math();
            //local variable definition
            int a, b;
            //calling a function to get the values 
            n.getValues(out a, out b);
            Console.WriteLine("The stored value of a is : {0}", a);
            Console.WriteLine("The store value of b is : {0}", b);

            //example of calling static class method
            msg.goodbyeMessage();
        }
    }
}
