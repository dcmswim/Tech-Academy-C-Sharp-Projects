using System;
using System.IO;

namespace DateTimeLogs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("The current date and time is: ");
            //gets the current datetime and saves it as a variable
            DateTime now = DateTime.Now;
            //prints current datetime to console
            Console.Write(now);

            Console.WriteLine("\nPlease enter a number.");
            //stores response as int variable
            int hoursNum = Convert.ToInt32(Console.ReadLine());
            //new datetime variable is stored, using AddHours method with previous int variable
            DateTime later = now.AddHours(hoursNum);
            Console.Write("The time after " + hoursNum + " hours will be: ");
            //prints new datetime after specified number of hours
            Console.Write(later);

            ////writes timestamp to external txt file to log each time the program is run
            ////Commented this block out for submission since file path only works on my home machine
            //using (StreamWriter file = new StreamWriter(@"C:\Visual_Studio_Projects\Logs\time_log.txt", true))
            //{
            //    file.WriteLine("Program accessed at: ");
            //    file.WriteLine(DateTime.Now);
            //}

            Console.ReadLine();

        }
    }
}
