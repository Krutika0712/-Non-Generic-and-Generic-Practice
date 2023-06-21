using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  // namespace to be include

namespace Practice1
{
    internal class arraylistEx
    {
        public static void main()
        {
            //Types of collections
            Console.WriteLine("---Array List--");
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add("Krutika");
            al.Add(null);  //Add(Object? value) --> ?-- only accept null 
            al.Add(true);
           //int i =Convert.ToInt32( al[0]);
           //string fruit = al[2].ToString();
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count: "+al.Count);
            Console.WriteLine("Capacity: "+al.Capacity);
            al.Remove(true);
            al.RemoveAt(1);
            Console.WriteLine("After Remove of false and position item");
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count: " + al.Count);
            Console.WriteLine("Capacity: " + al.Capacity);
        }
    }
}
