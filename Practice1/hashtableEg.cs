using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class hashtableEg
    {
        public static void main()
        {
            #region
            //Hashtable ht= new Hashtable();
            //ht.Add("1","ABC");
            //ht.Add("2", "Tcs");
            //ht.Add("3", "Birlasoft");
            //ht.Add("4", "Infosys");
            //ht.Add("5", null);
            //ht.Add("6", "XYZ");
            //Console.WriteLine("----------");
            //foreach (var item  in ht.Keys) 
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------");

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------");

            //foreach (DictionaryEntry de in ht)
            //{
            //    Console.WriteLine(de.Key+" "+de.Value);
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine("Enter the seach key");
            //string search=Console.ReadLine();
            //if(ht.ContainsKey(search)) 
            //{
            //    Console.WriteLine(ht[search]);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry item not found");
            //}

            //Dictionary<string, string> ht = new Dictionary<string, string>();   //Hashtable ht = new Hashtable();
            //ht.Add("1", "ABC");
            //ht.Add("2", "Tcs");
            //ht.Add("3", "Birlasoft");
            //ht.Add("4", "Infosys");
            //ht.Add("5", null);
            //ht.Add("6", "XYZ");
            //Console.WriteLine("----------");
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------");

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------");

            //foreach (KeyValuePair<string,string> de in ht)
            //{
            //    Console.WriteLine(de.Key + " " + de.Value);
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine("Enter the seach key");
            //string search = Console.ReadLine();
            //if (ht.ContainsKey(search))
            //{
            //    Console.WriteLine(ht[search]);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry item not found");
            //}
            #endregion
            Dictionary<int, string> ht = new Dictionary<int, string>();                                    //Hashtable ht = new Hashtable();
            ht.Add(1, "ABC");     //Keys must be unique and cannot be null.
            ht.Add(2, "Tcs");
            ht.Add(3, "Birlasoft"); //Values can be null or duplicate.
            ht.Add(4, "Infosys");
            ht.Add(5, null);
            ht.Add(6, "XYZ");
            Console.WriteLine("----------");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");

            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");

            foreach (KeyValuePair<int, string> de in ht)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
            Console.WriteLine("------ Search value ----");
            Console.WriteLine("Enter the seach key");
            int search = Convert.ToInt32(Console.ReadLine());
            if (ht.ContainsKey(search))
            {
                Console.WriteLine(ht[search]);
            }
            else
            {
                Console.WriteLine("Sorry item not found");
            }
            #region
            // Update value
            //Console.WriteLine("------ Update value ----");
            //Console.WriteLine("Enter the seach key");
            // int search = Convert.ToInt32(Console.ReadLine());
            //if (ht.ContainsKey(1 or search))    
            //{
            //    ht[1 or search] = "birlasoft";

            //}
            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
