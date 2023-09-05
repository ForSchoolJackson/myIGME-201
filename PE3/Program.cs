using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//get four numbers from user and display the product of those numbers

namespace ProductOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize numbers
            int nNum1 = 0;
            int nNum2 = 0;
            int nNum3 = 0;
            int nNum4 = 0;


            //promt user the enter a number
            Console.WriteLine("Enter a number");
            //try to convert to integer
            try
            {
                nNum1 = Convert.ToInt32(Console.ReadLine());
            }
            //if not write out a messege
            catch
            {
                Console.WriteLine("Not a Number");
            }

            //reapeat for number 2
            Console.WriteLine("Enter a number");
            try
            {
                nNum2 = Convert.ToInt32(Console.ReadLine());
            }
            //if not write out a messege
            catch
            {
                Console.WriteLine("Not a Number");
            }
            //number 3
            Console.WriteLine("Enter a number");
            try
            {
                nNum3 = Convert.ToInt32(Console.ReadLine());
            }
            //if not write out a messege
            catch
            {
                Console.WriteLine("Not a Number");
            }
            //number 4
            Console.WriteLine("Enter a number");
            try
            {
                nNum4 = Convert.ToInt32(Console.ReadLine());
            }
            //if not write out a messege
            catch
            {
                Console.WriteLine("Not a Number");
            }

            //show the product of the numbers
            Console.WriteLine("Product is:"+ (nNum1*nNum2*nNum3*nNum4));

        }


        }
}
