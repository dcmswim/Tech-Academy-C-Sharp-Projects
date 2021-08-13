using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //this class inherits from class 'Person'
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //using method from inherited class
        //in this case it is using method same as is defined in parent method with no changes
        public override void SayName()
        {
            base.SayName();
        }
        //class must use this method since it is a requirement of the inherited interface
        public void Quit()
        {
            Console.WriteLine("Termination notice received. Employee will be removed.");
        }

        //overloading '==' operator to check if 2 employee objs are same by comparing Id property
        public static bool operator== (Employee a, Employee b)
        {
            return (a.Id==b.Id);
        }
        public static bool operator!= (Employee a, Employee b)
        {
            return (a.Id!=b.Id);
        }
       
        }
    }
}
