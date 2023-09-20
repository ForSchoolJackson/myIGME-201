using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_8
{
    //jackson heim
    //program class
    internal class Program
    {
        //takes a user entered string and replaces all "no" with "yes"
        //do not replace words with no in it, just the words
        static void Main(string[] args)
        {

            //ask user to write something
            Console.WriteLine("write down a phrase with the word no in it");

            //get the string
            string userString = Console.ReadLine();

            //final string 
            string finalString = null;

            //to lower case
            userString = userString.ToLower();

            //replace the no with yes
            //case insensitive

            //break it up into words
            string [] userWords = userString.Split(' ');
            foreach(string word in userWords)
            {
                //if the word is no
                if (word == "no")
                {
                    //change no to yes
                    finalString += word.Replace("no", "yes");
                    //add a space
                    finalString += " ";
                }
                else
                {
                    //add the word
                    finalString += word;
                    //add space
                    finalString += " ";
         
                }
          
              
            }
            //write final string
            Console.WriteLine(finalString);


        }
    }
}
