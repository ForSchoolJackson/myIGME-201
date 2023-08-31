using System;



namespace SquashTheBugs

{

    // Class Program 

    // Author: David Schuh 

    // Purpose: Bug squashing exercise 

    // Restrictions: None 

    class Program

    {

        // Method: Main 

        // Purpose: Loop through the numbers 1 through 10  

        //          Output N/(N-1) for all 10 numbers 

        //          and list all numbers processed 

        // Restrictions: None 

        static void Main(string[] args)

        {

            // declare int counter 

            //int i = 0 -----syntax error: missing semicolin
            int i = 0;

            //new string varible placement
            string allNumbers = null;


            // loop through the numbers 1 through 10 

            //for (i = 1; i < 10; i++)-----logical error: goes up to ten but does not include it when counting
            for (i = 1; i <= 10; i++)


            {

                // declare string to hold all numbers 

                //string allNumbers = null;-----logical error: varible not declared in right place



                // output explanation of calculation 

                //Console.Write(i + "/" + i - 1 + " = ");----syntax error: have to put i-1 in ()
                Console.Write(i + "/" + (i - 1) + '=');



                // output the calculation based on the numbers 

                //Console.WriteLine(i / (i - 1));-----Runtime error: cannot divide by zero
                if (i == 1)
                {
                    Console.WriteLine("undifined");
                }
                else
                {
                    Console.WriteLine(i / (i - 1));


                }



                // concatenate each number to allNumbers 

                allNumbers += i + " ";



                // increment the counter 

                //i = i+1;----logical error: makes i skip by twos instead of going in order
                i = i++;


            }



            // output all numbers which have been processed 

            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);

        }

    }

}