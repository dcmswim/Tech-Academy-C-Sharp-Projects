using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoParameterMethods
{
    public class Math
    {   //num2 has a default value. Will only change if user specifies when the method is called by main()
        public static void math1(int num1, int num2 = 20)
        {
            int result = num1 + num2;
            Console.WriteLine("The result is: " + result);
        }
    }
}
