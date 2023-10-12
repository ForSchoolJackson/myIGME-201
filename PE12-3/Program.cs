using System;
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

        public virtual string GetString()
        {
            return myString;
        }
        public string MyString
        {
            set
            {
                myString = value;
            }
        }




    }

    //child class
    class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from derived class)";
        }
    }

}

