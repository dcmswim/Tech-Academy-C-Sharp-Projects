using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {   //opening console message
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            //Ask console question
            Console.WriteLine("\nWhat is your name?");
            //user response stored as string variable
            string name = Console.ReadLine();
            //console response with previously stored variable
            Console.WriteLine("Hello, " + name + "!");
            //Ask console question
            Console.WriteLine("\nWhat course are you on?");
            //user response stored as string variable
            string course = Console.ReadLine();
            //console response with previously stored variable
            Console.WriteLine(course + " sounds very interesting!");
            //Ask console question
            Console.WriteLine("\nWhat page of the course are you currently on?");
            //user response stored as integer variable
            int page = Convert.ToInt32(Console.ReadLine());
            //console response with previously stored variable
            Console.WriteLine("\nSo, you are on page " + page + "? Keep up the good work!");
            //ask console question
            Console.WriteLine("\nDo you need help with anything? Please answer \"True\" or \"False\"");
            //user response stored as boolean variable
            bool answer = Convert.ToBoolean(Console.ReadLine());
            //console response
            Console.WriteLine("\nIf you still need help, please reach out to instructor@learncodinganywhere.com");
            //ask console questions
            Console.WriteLine("\nWere there any positive experiences you'd like to share?");
            //user response stored as string variable
            string response = Console.ReadLine();
            //console response
            Console.WriteLine("\nThank you for your response.");
            //ask console questions
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            //user response stored as string variable
            string feedback = Console.ReadLine();
            //console response
            Console.WriteLine("\nThank you for the feedback!");
            //ask console question
            Console.WriteLine("\nHow many hours did you study today?");
            //user response stored as integer variable
            int hours = Convert.ToInt32(Console.ReadLine());
            //console response with previously stored variable
            Console.WriteLine("\nGood job studying for " + hours + " hours today!");
            //final console message
            Console.WriteLine("\nThank you for your answers. An instructor will respond to this shortly." +
                " Have a great day!");
            //ensures console stays open until it is manually closed
            Console.ReadLine();




        }
    }
}
