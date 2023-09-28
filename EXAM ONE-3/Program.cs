using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_ONE_3
{

    //program class
    //jackson heim
    internal class Program
    {
        /// delegate steps
        /// 1. define the delegate method data type based on the method signature
        ///         delegate double MathFunction(int n1, int n2);
        /// 2. declare the delegate method variable
        ///         MathFunction processDivMult;
        /// 3. point the variable to the method that it should call
        ///         processDivMult = new MathFunction(Multiply);
        /// 4. call the delegate method
        ///         nAnswer = processDivMult(n1, n2); <summary>

        //define delegate
        delegate double RoundNumber(double num);

        //create and use a delegate to impersonate the Math.Round(double, int) function
        static void Main(string[] args)
        {

            //declare delegate method variable
            RoundNumber myRoundNumber;

            //point the vairbale to the method to call
            myRoundNumber = new RoundNumber(Round);


            //test
            Console.WriteLine(myRoundNumber(2.22));
            Console.WriteLine(myRoundNumber(4.55949494));
        }

        static double Round(double num)
        {
            //round to be able to convert
            num = Math.Round(num, 0);
            //covert into int
            int rNum = Convert.ToInt32(num);
            //retrun the number
            return rNum; 
        }
    }
}
