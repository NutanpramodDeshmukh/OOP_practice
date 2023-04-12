using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class DemoEncap
    {

        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String studentName;
        private int studentAge;

        // using accessors to get and
        // set the value of studentName
        public String Name
        {

            get { return studentName; }

            set { studentName = value; }
        }

        // using accessors to get and
        // set the value of studentAge
        public int Age
        {

            get { return studentAge; }

            set { studentAge = value; }
        }
    }

}
