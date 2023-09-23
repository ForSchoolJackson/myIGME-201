using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

//math quiz with an added timer
//i had trouble getting the code to go back to the problems when the timer went out bacue it is in a different void
//had to make the user enter a zero when the timer ran out to get it to work
//it DOES NOT work otherwise
namespace MathQuiz
{
    //jackson heim
    //program class
    static class Program
    {
        //set up the timer
        static Timer timeOutTimer;
        //timer is not up yet
        static bool bTimeOut = false;

        //the math quiz gotten from lecture code
        static void Main(string[] arg)
        {
            // store user name
            string myName = "";

            // string and int of # of questions
            string sQuestions = "";
            int nQuestions = 0;

            // string and base value related to difficulty
            string sDifficulty = "";
            int nMaxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            // question and # correct counters
            int nCntr = 0;
            int nCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            int val1 = 0;
            int val2 = 0;
            int nAnswer = 0;

            // string and int for the response
            string sResponse = "";
            Int32 nResponse = 0;

            // play again?
            string sAgain = "";

            bool bValid = false;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // seed the random number generator
            Random rand = new Random();

            Console.WriteLine("Math Quiz!");
            Console.WriteLine();

            // fetch the user's name into myName
            while (true)
            {
                Console.Write("What is your name-> ");
                myName = Console.ReadLine();

                int len = myName.Length;
                //if( !len )
                if (myName.Length > 0)
                {
                    break;
                }
            }

        // label to return to if they want to play again
        start:

            // initialize correct responses for each time around
            nCorrect = 0;

            Console.WriteLine();

            // ask how many questions until they enter a valid number
            do
            {
                Console.Write("How many questions-> ");
                sQuestions = Console.ReadLine();
                bValid = int.TryParse(sQuestions, out nQuestions);
            } while (!bValid);

            Console.WriteLine();

            // ask difficulty level until they enter a valid response
            do
            {
                Console.Write("Difficulty level (easy, medium, hard)-> ");
                sDifficulty = Console.ReadLine();
                sDifficulty = sDifficulty.ToLower().Trim();

                //sDifficulty.ToLower();  does NOT change the contents of sDifficulty!
            } while (sDifficulty != "easy" &&
                      sDifficulty != "medium" &&
                      sDifficulty != "hard");

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (sDifficulty)
            {
                case "easy":
                    nMaxRange = MAX_BASE;

                    if (myName.ToLower() == "david")
                    {
                        goto case "hard";
                    }
                    break;

                case "medium":
                case "med":
                    nMaxRange = MAX_BASE * 2;
                    break;

                case "hard":
                    nMaxRange = MAX_BASE * 3;
                    break;
            }

            // ask each question
            for (nCntr = 0; nCntr < nQuestions; ++nCntr)
            {
                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 3);

                val1 = rand.Next(0, nMaxRange) + nMaxRange;
                val2 = rand.Next(0, nMaxRange);

                // if either argument is 0, pick new numbers
                if (val1 == 0 || val2 == 0)
                {
                    --nCntr;
                    continue;
                }

                // if nOp == 0, then addition
                // if nOp == 1, then subtraction
                // else multiplication
                if (nOp == 0)
                {
                    nAnswer = val1 + val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} + {val2} => ";
                }
                else if (nOp == 1)
                {
                    nAnswer = val1 - val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} - {val2} => ";

                }
                else
                {
                    nAnswer = val1 * val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} * {val2} => ";
                }

                bValid = false;

                //create a timer for 5 seconds
                timeOutTimer = new Timer(5000);

                //calls on timer elapsed event handler
                timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

                //start timer
                timeOutTimer.Start();

                // display the question and prompt for the answer until they enter a valid number
                do
                {
                    Console.Write(sQuestions);
                    sResponse = Console.ReadLine();

                    try
                    {
                        nResponse = int.Parse(sResponse);
                        bValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("please enter an integer.");
                        bValid = false;
                    }
                } while (!bValid);

                //end timer
                timeOutTimer.Stop();

                // if response == answer and TIME IS NOT OUT, output flashy reward and increment # correct
                // else output stark answer
                if (nResponse == nAnswer && bTimeOut == false)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Well done, {0}!!", myName);
                    ++nCorrect;
                }
                //get back into loop from the timer, cuz idk
                else if(nResponse == 0)
                {
                }
                //if answer is wrong
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry {0}, the answer is {1}", myName, nAnswer);
                }

                // restore the screen colors
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }

            Console.WriteLine();

            // output how many they got correct and their score
            Console.WriteLine("You got {0} correct out of {1}, which is a score of {2:P2}", nCorrect, nQuestions, (double)nCorrect / nCntr);

            Console.WriteLine();

            do
            {
                // prompt if they want to play again
                Console.Write("Do you want to play again? ");

                sAgain = Console.ReadLine();

                // if they type y or yes then play again
                // else if they type n or no then leave this loop
                if (sAgain.ToLower().Trim().StartsWith("y"))
                {
                    goto start;
                }
                else
                {
                    break;
                }
            } while (true);
        }

        //timer function for when the time is up
        //I have no idea how t ghet out of this boid into the main one again so i cheesed it
        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            //tell them time is up
            Console.WriteLine("Your time is up!");
            
            Console.ForegroundColor = ConsoleColor.White;

            //dont know how to get this to work so just make them enter a 0
            Console.WriteLine("please enter a zero");

            //make timer start over
            bTimeOut = false;
            
        }
    }
}



