using System;

namespace CallMethod
{
    public class Program
    {
        public static void Main()
        {
            
            try
            {
                Console.WriteLine("Please enter a number.");
                //stores user response as integer variable
                int opNum = Convert.ToInt32(Console.ReadLine());
                //calls methods from class Math, passing in integer variable opNum
                Math.add(opNum);
                Math.mult(opNum);
                Math.sub(opNum);
                
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please only enter whole numbers.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
