using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //instantiate new list of class Employee
            List<Employee> empList = new List<Employee>()
            {
                //records added to newly instaniated list 'empList'
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Bill", LastName = "Hobbs" },
                new Employee() { Id = 3, FirstName = "Bob", LastName = "Jones" },
                new Employee() { Id = 4, FirstName = "Sarah", LastName = "Hill" },
                new Employee() { Id = 5, FirstName = "Steve", LastName = "Marshall" },
                new Employee() { Id = 6, FirstName = "Ben", LastName = "Dover" },
                new Employee() { Id = 7, FirstName = "Joe", LastName = "Mama" },
                new Employee() { Id = 8, FirstName = "Homer", LastName = "Simpson" },
                new Employee() { Id = 9, FirstName = "Guy", LastName = "RealPerson" },
                new Employee() { Id = 10, FirstName = "Alex", LastName = "Hansen" }
            };


            ////using nested for loop returns all employee records with first name 'Joe'
            //for (int i = 0; i < empList.Count; i++)
            //{
            //    if (empList[i].FirstName == "Joe") 
            //    {
            //        Console.WriteLine("Name: " + empList[i].FirstName + " " + empList[i].LastName + " ID: " + empList[i].Id);
            //    }

            //}


            //using lambda expression does the same thing as the above for each loop
            //Finds matches where FirstName variable is 'Joe'
            List<Employee> checkName = empList.Where(x => x.FirstName == "Joe").ToList();                 
            foreach (var y in checkName)
            {
                Console.WriteLine("Employee ID: " + y.Id + ". First name: " + y.FirstName + ". Last name: " + y.LastName);
            }
            Console.ReadLine();
        }
    }
}
