using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class ArrayEx
    {
        public static void main()
        {
            Console.WriteLine("Enter the Size of Array ");
            int Size=Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[Size];
            Console.WriteLine("Enter Marks");
            for (int i=0;i<Size;i++) 
            {
                marks[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Dispaly Marks");
            for(int i = 0; i < Size; i++)
            {
                Console.WriteLine("Marks" + marks[i]);
            }
        }
    }
}
