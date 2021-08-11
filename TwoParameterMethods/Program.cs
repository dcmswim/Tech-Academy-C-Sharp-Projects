using System;

namespace TwoParameterMethods
{
   public class Program
    {
       public static void Main()
        {
            try
            {   
                //instantiate class
                Math math1 = new Math();
                Console.WriteLine("Please enter a number.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Would you like to enter another number? (Y/N)");
                string YesOrNo = Console.ReadLine();
                //makes response uppercase in user inputs lower case "y"
                YesOrNo = YesOrNo.ToUpper();
                if (YesOrNo == "Y")
                {
                    Console.WriteLine("Please enter the second number.");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Math.math1(num1, num2);
                    Console.ReadLine();
                }
                else
                {
                    //if user does not opt to input second integer only 1 parameter will be passed into math1() function
                    //second parameter for math1() has a default value in the class Math
                    Console.WriteLine("Okay, the computer will choose the second digit. \nCalculating answer...");
                    Math.math1(num1);
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Error occurred. Please only input whole integers.");
            }
            finally
            {
                Console.ReadLine();
            }
            



        }
    }
}
