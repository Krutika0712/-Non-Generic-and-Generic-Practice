using Practice1;
using System;
using System.Reflection;

namespace Practice1
{
    public class HelloWorld
    {
        public static void main(string[] args)
        {
            //int x = 10;
            var y = "Krutika"; // at Compilation time the datatype is set.
            //x=20.8f;
            //y=23;
            Console.WriteLine("---Variable");
            Console.WriteLine(y.GetType()); // get type() is an extension method
            Console.WriteLine("---Dynamic");
            dynamic d = "Krutika";
            d = 10;
            d = false;
            d = 20.45f;
            Console.WriteLine(d.GetType());

        }
    }
}