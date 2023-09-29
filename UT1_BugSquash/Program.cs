
using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY --- compile time error (missing semicolin)
            int nY;

            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);---compile time error (missing "")
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); ----logical error (needed to set it equal to the sNumber)
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } //while (int.TryParse(sNumber, out nX)); ----logical error(want to tryParse the y value not the x)
              //(also need to put ! so so it leaves the while loop when the parse works instead of when it doesnt work) 
              while (!int.TryParse(sNumber, out nY)) ;

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); --- logical error (does not write out the vairbles or answer)
            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer);
        }


        //int Power(int nBase, int nExponent)--- compile timer error(need to have static or void inn front of a function)
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; ----logical error (also the returnVal should = 1 not zero)
                returnVal = 1;
                
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); ---logical error(should be -1)--- run time error(cuased it to crash)
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal;----- compile time error (not how you return the return val)
            return returnVal;
        }
    }
}
