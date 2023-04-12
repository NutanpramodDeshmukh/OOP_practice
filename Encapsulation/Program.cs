using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object
        DemoEncap obj = new DemoEncap();

            // calls set accessor of the property Name,
            // and pass "Ankita" as value of the
            // standard field 'value'
            obj.Name = "nutan";
            

            // calls set accessor of the property Age,
            // and pass "21" as value of the
            // standard field 'value'
            obj.Age = 24;

            // Displaying values of the variables
            Console.WriteLine(" Name : " + obj.Name);
            Console.WriteLine(" Age : " + obj.Age);
        }
    }
}
