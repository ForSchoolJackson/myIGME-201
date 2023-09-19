using System;

namespace PE6
{
    //class program
    //Jackson Heim
    internal class Program
    {
        //main method
        //create a geussing game by creating a random integer from 0-100
        //have the player try to guess what it is in 8 turns
        static void Main(string[] args)
        {
            //varibale for the string user inputs
            string sInput = null;

            //variable for the int gotten from user input
            int nInput = 0;

            //variable for number of turns
            int turns = 0;

            //create the random number
            Random rand = new Random();

            //generate the random number in the range of 0-100
            int randomNumber = rand.Next(0, 101);

            //print random number at the top of the console
            Console.WriteLine(randomNumber);

            //loop to give user 8 tries to guess the number
            for (int i = 0; i < 8; ++i)

            {

                // loops until both are numbers
                do
                {
                    //promt user to take turn guessing
                    Console.Write("Turn " + (i + 1) + ": Enter your guess: ");
                    //read user input and turn to string
                    sInput = Console.ReadLine();

                    try
                    {

                        // convert string to int
                        nInput = Convert.ToInt32(sInput);

                        //checked if it is a number in the range of 0 and 100
                        if (nInput >= 0 && nInput <= 100)
                        {

                            //test if guessed number is higher, lower or correct
                            //number is too high
                            if (nInput > randomNumber)
                            {
                                Console.WriteLine("Too high");

                                //move on
                                break;
                            }
                            //number is too low
                            else if (nInput < randomNumber)
                            {
                                Console.WriteLine("Too low");

                                //move on
                                break;
                            }
                            //number is correct
                            else if (nInput == randomNumber)
                            {
                                //find how many turns
                                turns = (i + 1);
                                //escape the whole loop
                                goto endOfGame;
                            }

                        }
                        //if false make them try again
                        else
                        {
                            // ask user to try again
                            Console.WriteLine("Invalid guess----Try Again");

                        }


                    }

                    catch
                    {
                        // ask user to try again
                        Console.WriteLine("Invalid guess----Try Again");

                    }


                } while (true);


            }
            //begin at the end of the game
        endOfGame:
            //indent line
            Console.WriteLine("");
            //if the answer was guessed, tell them and write out how many turns they took
            if (nInput == randomNumber)
            {
                Console.WriteLine("CORRECT! Finished in " + turns + " turn(s).");
            }
            //if it was not guessed in the eight turns tell them they ran out of turns
            else
            {
                Console.WriteLine("Ran out of turns. Number was " + randomNumber);
            }

        }
    }
}
