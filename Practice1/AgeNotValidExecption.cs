using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class AgeNotValidExecption:ApplicationException
    {
        public AgeNotValidExecption(string message) : base(message) { } // base class initialization
    }
  
    class VotingEx
    {
        public int Age { get; set; }
       
      
        public void checkAge(int age)
        {
            if (age < 18)
            {
                throw new AgeNotValidExecption("Sorry ! u are not eligible to vote!!");
            }
            else
            {
                Console.WriteLine(" Thank for voting!!");
            }
        }
    }
    class votaingClient
    {
        public static void main()
        {
            VotingEx c1 = new VotingEx();
           
           
            Console.WriteLine("enter Age:");
            try
            {
                
                c1.Age = Convert.ToInt32(Console.ReadLine());
                c1.checkAge(c1.Age);

            }
          
            //catch (FormatException)
            //{
            //    Console.WriteLine("Enter only number");
            //}
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (AgeNotValidExecption e)
            //{
            //    Console.WriteLine(e.Message);
            //}
          
        }
    }
}

