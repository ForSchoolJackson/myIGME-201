using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//build solution is cntrl+shif+B
//start debugging is F5
//start without debugging is Cntrl+F5
//format document is cntrl+K

//namespace for organiing code
namespace HelloWorld
{

    //c# starts with one class, this is where most code goes
    internal class Program
    {
        //the main is the starting point for the code
        static void Main(string[] args)
        {
            //print hello world
            Console.WriteLine("Hello World!");
            //print my name
            Console.WriteLine("Jackson Heim");

            //create variables
            int Num1 = 2;
            //let Num1=2 doesnt work in c#

            //math calculations
            int Num2 = 1+7;

            //print results
            Console.WriteLine(Num1);
            Console.WriteLine(Num2);

            //implicit vs explicit casting
            int Result = Num1+Num2;
            Console.WriteLine(Result);

            //if statements
            if (Num1 == 2)
            {
                Console.WriteLine("Number 1 is 2");
            }else if(Num1 == 1)
            {
                Console.WriteLine("Number 1 is 1");
            }

            //for loop
            for(int a = 0; a < Result; a++)
            {
                Console.WriteLine("a="+a);
            }

            //while loop
            int B = 0;
            while (B < Num2)
            {
                Console.WriteLine("B="+B);
                B++;
            }

     
            


        }
    }
}
