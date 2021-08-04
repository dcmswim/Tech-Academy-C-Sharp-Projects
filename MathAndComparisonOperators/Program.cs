using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            // --- MATH OPERATORS --- //

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("10 minus 5 equals " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();


            // --- COMPARISON OPERATORS --- //

            //bool trueorFalse = 12 > 5;
            //Console.WriteLine(trueorFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            // --- MATH OPERATOR PRACTICE --- //

            Console.WriteLine("Please input a number to be multiplied by 50.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int result1 = input1 * 50;
            Console.WriteLine(input1 + " multipled by 50 equals: " + result1);

            Console.WriteLine("\nPlease input another number which will have 25 added to it.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result2 = input2 + 25;
            Console.WriteLine(input2 + " plus 25 equals: " + result2);

            Console.WriteLine("\nPlease input a number to be divided by 12.5");
            int input3 = Convert.ToInt32(Console.ReadLine());
            double result3 = input3 / 12.5;
            Console.WriteLine( input3 + " divided by 12.5 equals: " + result3);

            Console.WriteLine("\nPlease input a number and I will check if it's greater than the secret number.");
            int input4 = Convert.ToInt32(Console.ReadLine());
            bool result4 = input4 > 50;
            Console.WriteLine("\nIs your number greater than the secret number? Let's check.... : " + result4);

            Console.WriteLine("\nInput a number to be divided by 7. The returned result will be the remainder.");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int result5 = input5 % 7;
            Console.WriteLine("\nThe resulting remainder is: " + result5);
            


            




        }
    }
}
