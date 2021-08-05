using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro console message
            Console.WriteLine("Anonymous Income Comparison Program");

            //Gets information from person1 and stores values as variables
            Console.WriteLine("\nPerson 1, please input your name.");
            string name1 = Console.ReadLine();
            Console.WriteLine("\nHello, " + name1 + ". What is your hourly rate of pay?");
            //converts input to a decimal since calculations will be financial
            decimal pay1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nHow many hours did you work this week, " + name1 + "?");
            decimal hours1 = Convert.ToDecimal(Console.ReadLine());
            //calculates weekly pay by multiplying hours worked by hourly rate of pay
            decimal weeklyPay1 = pay1 * hours1;
            Console.WriteLine("\nYour paycheck for this week is: $" + weeklyPay1);
            decimal salary1 = weeklyPay1 * 52;
            Console.WriteLine("\nIf you continue to work " + hours1 + " hours per week, your annual salary will amount to: $" + salary1);


            Console.WriteLine("\n Person 2, please input your name.");
            string name2 = Console.ReadLine();
            Console.WriteLine("\nHello, " + name2 + ". What is your hourly rate of pay?");
            //converts input to decimal since calculations will be financial
            decimal pay2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nHow many hours did you work this week, " + name2 + "?");
            decimal hours2 = Convert.ToDecimal(Console.ReadLine());
            //calculates weekly pay by multiplying hours worked by hourly rate of pay
            decimal weeklyPay2 = pay2 * hours2;
            Console.WriteLine("\nYour paycheck for this week is: $" + weeklyPay2);
            decimal salary2 = weeklyPay2 * 52;
            Console.WriteLine("\nIf you continue to work " + hours2 + " hours per week, your annual salary will amount to: $" + salary2);

            //comparison - checks values of previous calculations and returns true or false 
            //if salary1 is greater than salary 2 True will be returned. Return will be false is salary1 is less than salary2
            bool salaryCompare = salary1 > salary2;
            Console.WriteLine("\nAt this rate, will " + name1 + " make more per year than " + name2 + "? Let's check...");
            Console.WriteLine(salaryCompare);
            Console.ReadLine();
        }
    }
}
