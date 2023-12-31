﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_3
{
    //parent class
    public class MyClass
    {
        private string myString;
        //get string method
        public virtual string GetString()
        {
            return myString;
        }
        //write only property for my string
           public string MyStringProp
        {
            set
            {
                myString = value;
            }
        }
     
    }

    //child class fo MyCLass
    public class MyDerivedClass : MyClass
    {
        //ovveride the old GetString from parent to change it 
        public override string GetString()
        {
            return base.GetString() + " (output from derived class)";
        }
    }

    //program class
   public class Program
    {
        static void Main(string[] args)
        {
            //instantiate the child class
            MyDerivedClass myDeriv = new MyDerivedClass();
            //write the line on console
            Console.WriteLine(myDeriv.GetString());


        }
    }

}

