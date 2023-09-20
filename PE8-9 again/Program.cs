using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_9
{
    //jackson heim
    //program class
    internal class Program
    {
        //puts quotes areound each word in a user entered string
        static void Main(string[] args)
        {

            //ask user to enter a string
            Console.WriteLine("please enter a sentance");

            //get the string from user
            string userString = Console.ReadLine();

            //break up the string into words
            string[] userWords = userString.Split(' ');

            //final string
            string finalString = null;

            //run thbough each word
            foreach (string word in userWords)
            {
                //add the double quotes arounf each word
                finalString += ("\"" + word + "\"");
                //add a space
                finalString += " ";
            }

            //show finbal string
            Console.WriteLine(finalString);
        }
    }
}
