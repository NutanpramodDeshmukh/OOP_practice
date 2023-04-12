using System;


namespace Scops
{
    static void Value(int x)
    {
        x = 200;

        Console.WriteLine(x);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            Console.WriteLine(i);

            Value(i);

            Console.WriteLine(i);
        }
    }
}
