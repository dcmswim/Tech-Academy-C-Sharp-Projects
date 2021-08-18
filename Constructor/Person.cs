using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person
    {
        private string Id = "";
        private string fname = "";
        private string lname = "";

        //example of constructor chaining
        public Person(string Id) : this(Id, "", "")
        {
            //constructor with one parameter
        }

        public Person(string Id, string fname) : this(Id, fname, "")
        {
            //constructor with 2 parameters
        }

        public Person(string Id, string fname, string lname)
        {
            //constructor with 3 parameters
            this.Id = Id;
            this.fname = fname;
            this.lname = lname;
        }




        
    }
}
