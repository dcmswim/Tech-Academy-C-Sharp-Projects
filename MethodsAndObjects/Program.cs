using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class 
            Employee employee= new Employee();
            //assigning values to class properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //calling superclass method from parent class 'Person' inherited by 'Employee'
            employee.SayName();
            Console.ReadLine();
        }
    }
}
