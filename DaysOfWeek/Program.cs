using System;

namespace DaysOfWeek
{
    class Program
    {
        public enum whatDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the day of the week.");
                string response = Console.ReadLine();
                //parses through enum 'whatDay' to check if response matches
                //note - this is currently case sensitive
                whatDay day = Enum.Parse<whatDay>(response);
                Console.WriteLine("You entered: " + response);
            }

            //catch for when user response is not included in enum data 'whatDay'
            catch (Exception)
            {
                Console.WriteLine("Error, invalid response. Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }       
        }
    }
}
