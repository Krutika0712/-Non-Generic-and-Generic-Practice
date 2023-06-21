using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class List
    {
        public static void main()
        {

            #region
            // non-Generic collection :- value added can be hetrogeneous datatype(hetrogeneous:-it can be one string one int)
            // Queue:- First in First out
            //Queue q= new Queue();
            //Queue<int> q = new Queue<int>();
            // //q.Enqueue("ABC");  //Enqueue:- Adds an item into the queue.
            //q.Enqueue(2);
            //q.Enqueue(3);

            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("Item Removed: " + q.Dequeue()); //Dequeue:-Returns an item from the beginning of the queue and removes it from the queue.
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}
            //------------------------------------------------------------------------------------

            // Stack:- Last in First out
            //Stack s = new Stack();
            //Stack<int> s= new Stack<int>();
            //s.Push(1); //Push:-Inserts an item at the top of the stack.
            //s.Push(2);
            //s.Push(3);
            //foreach (int i in s)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Item Removed: " + s.Pop()); //Pop:-Removes and returns items from the top of the stack.
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //Array using 1)List<>
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            List<string> name = new List<string>();
            name.Add("a");
            name.Add("b");
            name.Add("c");
            foreach (string n in name)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("------------------------");
            List<int> number = new List<int>();
            number.Add(1);
            number.Add(2);

            int[] copynumber = new int[6];
            foreach (int s in number)
            {
                for (int i = 0; i < number.Count; i++)
                {
                    copynumber[i] = s;
                    Console.WriteLine("Copy Number: " + copynumber[i]);
                }

            }
        }
    }
}
