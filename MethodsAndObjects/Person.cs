using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{   
    //defining abstract class
    //reminder - abstract class cannot be directly instatiated
    public abstract class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        //virtual method - can be used and/or altered by inheriting class
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " +  LastName);
        }
    }
}
