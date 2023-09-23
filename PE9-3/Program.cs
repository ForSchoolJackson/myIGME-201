using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_3
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


    // define delegate
    delegate string ReadFunction();

    //program class
    //jackson heim
    internal class Program
    {

        //use delegate function to impersonate console.readline
        static void Main(string[] args)
        {

            //declare delegate method variable
            ReadFunction processReadLine;
 
            //point to the method
            processReadLine = new ReadFunction(ReadLine);


            //test
            string word = processReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(word);

        }


        //method for reading line of console
        static string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}

