using System;
using System.Security;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            //variables for calculation
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            //strings for user imput
            string sImage = null;
            string sReal = null;
            //doubles for the imagcCoord and realCoord
            double imStart = 0;
            double imEnd = 0;
            double realStart = 0;
            double realEnd = 0;

        //PROMT FOR IMAGCOORD
        startOver:
            Console.WriteLine("Enter a start and end values for imagCoord.");
            Console.WriteLine("First number must be greater than the second number.");
            Console.WriteLine("Example: 1.2 to -1.2");
            for (int i = 0; i < 2; ++i)
            {
                do
                {
                    sImage = Console.ReadLine();

                    //make sure user inputs number
                    try
                    {

                        //convert start and end to numbers
                        if (i == 0)
                        {
                            imStart = Convert.ToDouble(sImage);

                        }
                        else
                        {
                            imEnd = Convert.ToDouble(sImage);
                        }

                        //move on
                        break;
                    }
                    catch
                    {
                        //tell them to try again and re enter numbers
                        Console.WriteLine("try again");

                    }
                } while (true);


            }

            //PROMT FOR REALCOORD
            Console.WriteLine("Enter a start and end values for realCoord.");
            Console.WriteLine("First number must be smaller than the second number. ");
            Console.WriteLine("Example: -0.6 to 1.77");
            for (int i = 0; i < 2; ++i)
            {
                do
                {
                    //promt user for realCoord
                    sReal = Console.ReadLine();

                    //make sure user inputs number
                    try
                    {
                        //convert start and end to numbers
                        if (i == 0)
                        {

                            realStart = Convert.ToDouble(sReal);
                        }
                        else
                        {

                            realEnd = Convert.ToDouble(sReal);
                        }

                        break;
                    }
                    catch
                    {
                        //tell them to try again
                        Console.WriteLine("try again");
                    }
                } while (true);

            }

            //check if valid
            if ((imStart < imEnd) || (realStart > realEnd))
            {
                Console.WriteLine("INVALID");
                goto startOver;
            }

            //find the correct incriments
            double imInc = (imStart / imEnd);
       



            //cycyle throguh coordinates for image
            for (imagCoord = imStart; imagCoord >= imEnd; imagCoord -= 0.05)
            {
                for (realCoord = realStart; realCoord <= realEnd; realCoord += 0.03)
                {
                    //initialize variables
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    //makes sure it doesnt go on forever
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    //chooses which charcter to output
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                //ends the line
                Console.Write("\n");
            }

        }
    }
}

