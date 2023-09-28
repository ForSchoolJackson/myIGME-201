using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EXAM_ONE_13
{

    //employee struct
    struct Employee
    {
        public string sName;
        public double dSalary;

    }

    //prgram class
    //jackson heim
    class Program
    {
        //main
        static void Main(string[] args)
        {

            Employee e = new Employee();

            //set salaray to 3000
            e.dSalary = 30000;

            //promt user name
            Console.WriteLine("what is your name?");
            e.sName = Console.ReadLine();

            //if give raise is true or not
            if (GiveRaise(ref e))
            {
                Console.WriteLine("Congratulations, you got a raise! Your new salary is " + e.dSalary + ".");
            }
            else
            {
                Console.WriteLine("No raise for you.");
            }


        }

        //function for increaing salery if name is my name
        static bool GiveRaise(ref Employee e)
        {
            if (e.sName.ToLower() == "jackson")
            {
                e.dSalary += 19999.99;

                return true;
            }
            else
            {
                return false;
            }
        }
    }







}

