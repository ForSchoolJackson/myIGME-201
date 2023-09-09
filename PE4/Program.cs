using System;


namespace Product

{

    class Program

    {

        // Method---Main
        // Get two numbers from the user and display them
        // Reject numbers if they are both greater than ten
        static void Main(string[] args)

        {
            // string for the user imput
            string sNum = null;
            // int for the converted string
            int nNum1 = 0;
            int nNum2 = 0;

        //place to start code over if both are greater than ten
        begin:
            // user must imput 2 times, loop twice
            for (int i = 0; i < 2; ++i)

            {

                // loops until both are numbers
                do
                {
                    //promt
                    Console.Write("Write a number. ");
                    //read user input and turn to string
                    sNum = Console.ReadLine();

                    try
                    {

                        // convert string to int
                        //only if varible is not already being used
                        if (i==0)
                        {
                            nNum1 = Convert.ToInt32(sNum);
                        }
                        else
                        {
                            nNum2 = Convert.ToInt32(sNum);
                        }

                        //move on
                        break;

                    }

                    catch
                    {
                        // please enter a number
                        Console.WriteLine("NOT A NUMBER ");

                    }

                } while (true);



            }

            //check if both are greater than ten
            //if true, try again
            //if false, display numbers
            if (nNum1 > 10 && nNum2 > 10)
            {
                //ask to try again then start at the begining
                Console.WriteLine("Try Again");
                goto begin;


            }
            else
            {
                //display the numbers
                Console.WriteLine("Numbers are " + nNum1 + " and " + nNum2);

            }

        }

    }
}







