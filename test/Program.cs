using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                string name = Console.ReadLine();
                //maker user put in something
                if (name.Length > 0)
                {
                    break;
                }

            } while (true);

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

        }
    }
}

