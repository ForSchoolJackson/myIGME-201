using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXAM_ONE_4
{
 
    //program class
    //jackson heim
    internal class Program
    {

        //copy the 3 questions application
        static void Main(string[] args)
        {
            //varibale for numbered question
            int nQuestion = 0;

            //user answer
            string uAnswer = null;
            //correct answer
            string cAnswer = null;

        //start of game
        start:
            //loop through until anwer is the number 1 2 or 3
            do
            {
                //ask user to pick a question 1-3
                Console.Write("Choose your question (1-3): ");
                string sQuestion = Console.ReadLine();

                //make sure it is a number
                try
                {
                    nQuestion = Convert.ToInt32(sQuestion);

                    //check if it is a number 1-3
                    if (nQuestion > 0 && nQuestion < 4)
                    {
                        //leave loop
                        break;

                    }

                }
                catch
                {
                    //goes back to start
                }


            } while (true);

            //explain time limit
            Console.WriteLine("You have 5 seconds to answer the following question: ");

            //the questions
            switch (nQuestion)
            {
                case 1:
                    //correct answer
                    cAnswer = "black";

                    Console.WriteLine("What is your favorite color?");

                    //check if answer is correct
                    uAnswer = Console.ReadLine();
                    if (uAnswer == cAnswer)
                    {
                        Console.WriteLine("Well Done!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!  The answer is: " + cAnswer);
                    }
                    break;

                case 2:
                    //correct answer
                    cAnswer = "42";

                    Console.WriteLine("What is the answer to life, the universe and everything?");

                    //check if answer is correct
                    uAnswer = Console.ReadLine();
                    if (uAnswer == cAnswer)
                    {
                        Console.WriteLine("Well Done!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!  The answer is: " + cAnswer);
                    }
                    break;

                case 3:
                    //correct answer
                    cAnswer = "What do you mean? African or European swallow?";

                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");

                    //check if answer is correct
                    uAnswer = Console.ReadLine();
                    if(uAnswer == cAnswer)
                    {
                        Console.WriteLine("Well Done!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!  The answer is: " + cAnswer);
                    }
                    break;
            }

            //ask user to play again
            do
            {
                Console.Write("Play again? ");
                string answer = Console.ReadLine();
                //make it lowercase
                answer = answer.ToLower();

                //if yes play game, if no leave
                switch (answer)
                {
                    case "yes":
                        Console.WriteLine(" ");
                        //start at begining
                        goto start;

                    case "no":
                        //go to the end of the program
                        goto endProgram;

                }



            } while (true);


            //i dont know how to force the program to quit right after so i added this
            //end of program
        endProgram:
            Console.WriteLine("GoodBye");

        }
        
    }
}


