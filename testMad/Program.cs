using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace test_app
{
    internal class Program
    {
        //create a madlibs game
        //promt user for different words
        //use template givin to make a story
        static void Main(string[] args)
        {

            //varibles for the chooing from the different stroies
            int nStory = 0;
            int count = 0;
            int nChoice = 0;

            //for the final output
            string sResult = "";

            //user names
            string name = null;

            StreamReader input;
            //open template file
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            //start at null
            string line = null;

            //make each line a diff number
            while ((line = input.ReadLine()) != null)
            {
                ++nStory;
            }

            //close it
            input.Close();

            //a string for each different madlib
            string[] madLibs = new string[nStory];

            //turn file into an array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            //reset line
            line = null;
            while ((line = input.ReadLine()) != null)
            {
                //set to current line
                madLibs[count] = line;

                //replace the "\\n" tag with newline
                madLibs[count] = madLibs[count].Replace("\\n", "\n");

                ++count;
            }

            //close it
            input.Close();

            do
            {
                //promt the user for name
                Console.WriteLine("What is your name? ");
                name = Console.ReadLine();
                //maker user put in something
                if (name.Length > 0)
                {
                    break;
                }

            } while (true);

            //ask if they want to play
            Console.WriteLine("Do you want to play madlibs {0}?", name);
            askYes: //start of asking user to play
            do
            {
                string answer = Console.ReadLine();
                //make it lowercase
                answer =answer.ToLower();

                //if yes play game, if no leave
                switch (answer)
                {
                    case "yes":
                        //start the madlibs promt
                        goto madlibsTime;

                    case "no":
                        //go to the end of the program
                        goto endProgram;
                        
                }

                    Console.WriteLine("Please write yes or no.");
                
            } while (true);
            
            
            madlibsTime: //start of madlibs promt
            //promt user for what number game they want to play
            do
            {
                Console.WriteLine("Pick a number from 0 to 5");


            } while (!int.TryParse(Console.ReadLine(), out nChoice));


            //split the chosen stroy into seperate words
            string[] words = madLibs[nChoice].Split(' ');

            //find the words that need replacing and promt user to replace them
            foreach (string word in words)
            {
                //find placeholder words by looking for beginng with {
                if (word[0] == '{')
                {
                    //NOT WORKING
                    //replace the symbols {, }, and _
                    // word = word.Replace("{", "").Replace("}", "").Replace("_", "");

                    //ask for replacement
                    Console.WriteLine("Enter a {0}: ", word);

                    //add it to story
                    sResult += Console.ReadLine();
                    //add spaces
                    sResult += " ";

                }
                else
                {
                    //if its a regular not replaced word
                    sResult += word;
                    //add spaces
                    sResult += " ";
                }



            }

            //show the final story
            Console.WriteLine(sResult);

            //ask if they want to play again
            Console.WriteLine("Do you want to play again {0}?", name);
            //go back up to where we asked the first time
            goto askYes;


        //END THE PROGRAM
        endProgram: //end of program
            Console.WriteLine("GoodBye!");
        }
    }
}



