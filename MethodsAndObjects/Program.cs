using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of using polymorphism to create 'IQuittable' object type
            IQuittable iQuit = new Employee();
            iQuit.Quit();
            
            //example of using 'Employee' class inherited interface method 'Quit'
            Employee quitter = new Employee();
            quitter.Quit();





            // ----- Section commented out for assignment example ----- //

            ////instantiate class 
            //Employee employee = new Employee();
            ////assigning values to class properties
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            ////calling superclass method from parent class 'Person' inherited by 'Employee'
            //employee.SayName();
            //Console.ReadLine();
        }
    }
}
