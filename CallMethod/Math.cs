using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethod
{   //defines class
    public class Math
    {   //method within class Math
        public static void add(int opNum)
        {
            int num1 = 15;
            int res1 = num1 + opNum;
            Console.WriteLine("Addition math result = " + res1);
        }
        //method within class Math
        public static void mult(int opNum)
        {
            int num2 = 12;
            int res2 = num2 * opNum;
            Console.WriteLine("Multiplication math result = " + res2);
        }
        //method within class Math
        public static void sub(int opNum)
        {
            int num3 = 5;
            int res3 = opNum - num3;
            Console.WriteLine("Subtraction math result = " + res3);
        }
        
            

        
    }
}
