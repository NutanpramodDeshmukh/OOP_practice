using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        // method does not take any parameter 
        public void greet()
        {
            Console.WriteLine("Hello");
        }

        // method takes one string parameter
        public void greet(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
        // method is overloaded
        void totalSum(int a, int b)
        {
            Console.WriteLine("The sum of numbers is " + (a + b));
        }

        // method adds two double-type numbers
        // totalSum() method is overloaded
        void totalSum(double a, double b)
        {
            Console.WriteLine("The sum of numbers is " + (a + b));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
           // Program p1 = new Program();

            // calls method without any argument
            //p1.greet();

            //calls method with an argument
            //p1.greet("Tim");

            Program sum1 = new Program();
            sum1.totalSum(5, 7);
            sum1.totalSum(53.5, 8.7);

            Polygon obj1 = new Polygon();

            // calls render() method of Polygon Superclass 
            obj1.render();

            // here, obj1 is the object of derived class Square 
            obj1 = new Square();

            // calls render() method of derived class Square
            obj1.render();
        }
    }
}
