using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class hashtableEx
    {
        public static void main() 
        {
            HashSet<string> cities =new HashSet<string>(); // display unique data
            cities.Add("Pune");
            cities.Add("Delhi");
            cities.Add("Pune");
            cities.Add("chennai");
            cities.Add("Pune");
            foreach (string s in cities)
            {
                Console.WriteLine(s);
            }




        }
    }
}
