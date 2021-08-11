using System;

namespace VoidMethod
{
    public class Program
    {
        static void Main(string[] args)
        { 
            int num1 = 5;
            int num2 = 10;
            //passing in predefined integer variables
            Math.add1(num1, num2);
            //passing in integers as plain integers
            Math.add1(15, 25);
            //passing in integer variables by name
            Math.add1(num1 = 20, num2 = 50);
        }
    }
}
