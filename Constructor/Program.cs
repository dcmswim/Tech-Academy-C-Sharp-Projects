using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class Program
    {
        static void Main(string[] args)
        {
            //declaring a constant variable
            const string welcome = "Hello! Welcome to this console application.";
            Console.WriteLine(welcome);

            Console.WriteLine("What is your first name?");
            string fname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();
            //using var keyword to create variable
            var fullName = fname + " " + lname;
            Console.WriteLine(fullName);

            Console.ReadLine();

        }
    }
}
