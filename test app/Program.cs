using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_app
{
    internal class Program
    {
        //sort user entered list of doubles
        static void Main(string[] args)
        {

            //
            double[] aUnsorted;
                double[] aSorted;



            start:
            Console.WriteLine("Enter a list of space-seperated numbers");

            //read space seperated numbers
            string sNumberString = Console.ReadLine();

            //split strin into an array of strings which are individual numvers
            string[] sNumbers = sNumberString.Split(' ');

            //initailize the size of the unsorted array to 0
            int nUnsortedLength = 0;

            //double used for parsing current array elemet
            double nThisNumber;

            //you can read through an array in multiple ways
            //foreach() cannot modify the arrays contents
            //it is read only
            //iterate through the array of number strings
            foreach (string sThisNumber in sNumbers)
            {
                //you cant change the iterator
                //this will cuase a compile-time error
                //sThisNumber = "";
                if(sThisNumber.Length == 0)
                {
                    //skip it
                    continue;

                }
                try
                {
                    //try parse the current string to double
                    nThisNumber = double.Parse(sThisNumber);
                }
                catch
                {

                }



            }




        }
    }
}
