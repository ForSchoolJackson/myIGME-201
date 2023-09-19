using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_7
{
    //jackson heim
    //program class
    internal class Program
    {

        //accepts a string from the user
        //outputs the string backwards
        static void Main(string[] args)
        {
            //ask user to write a string
            Console.WriteLine("write something down please");

            //get the users sting
            string userString = Console.ReadLine();

            //turn userString into an array of characters
            char[] charArray = userString.ToCharArray();

            //reverse the array
            Array.Reverse(charArray);

            //wrtie out final
            Console.WriteLine(charArray);

        }
    }
}
