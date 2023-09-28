using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_ONE_12
{
    //program class
    //jackson heim
    internal class Program
    {
        //promt user name and give raise if correct person
        static void Main(string[] args)
        {
            //declerations
            string sName;
            double dSalary = 30000;

            //promt user name
            Console.WriteLine("what is your name?");
            sName = Console.ReadLine();

            if(GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congratulations, you got a raise! Your new salary is " + dSalary+ ".");
            }
            else
            {
                Console.WriteLine("No raise for you.");
            }
 

        }

        //function for increaing salery if name is my name
        static bool GiveRaise(string name, ref double salary)
        {
            if(name.ToLower() == "jackson")
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
