using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Polygon
    {
        // method to render a shape
        public virtual void render()
        {
            Console.WriteLine("Rendering Polygon...");
        }
    }

    class Square : Polygon
    {
        // overriding render() method 
        public override void render()
        {
            Console.WriteLine("Rendering Square...");
        }
    }
}
