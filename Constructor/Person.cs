using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person
    {
        public string fname {  get; set; }
        public string lname {  get; set; }
        public int credits { get; set; }

        public Person(string fname, string lname) : this(50)
        {
            Console.WriteLine(fname + lname);
        }

        public Person(int credits)
        {
            
        }

    }
}
