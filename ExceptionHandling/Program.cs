using System;
using System.Collections.Generic;

class Program
 {
    static void Main(string[] args)
    {
        try
        {
            List<int> numList = new List<int>() { 10, 20, 35, 50, 100, 3550 };
            Console.WriteLine("Please enter a number.");
            int divOp = Convert.ToInt32(Console.ReadLine());
            //iterates through list of integers
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i] + " divided by " + divOp + " equals: " + (numList[i] / divOp));
            }

        }
        //catch for when user input is not an integer
        catch (FormatException)
        {
            Console.WriteLine("Please only type whole numbers.");
        }
        //catch for when user attempts to divide by 0
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by 0.");
        }
        finally
        {
            Console.WriteLine("\nEnd of program.");
            Console.ReadLine();
        }

        
        
        
        
        
        
        
        
        
        
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number");
        //    int num2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two numbers...");
        //    int num3 = num1 / num2;
        //    Console.WriteLine("Result equals: " + num3);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please only type a whole number.");
        //    return;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Impossible to divide by 0.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}
        

    }
}

