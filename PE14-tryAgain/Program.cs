using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    public interface IClass
    {
        void MyString();
    }

    public class ClassOne : IClass
    {
        public void MyString()
        {
            Console.WriteLine("String for class one.");
        }
    }

    public class ClassTwo : IClass
    {
        public void MyString()
        {
            Console.WriteLine("String for class two.");
        }
    }


    //program class
    internal class Program
    {
        //main
        static void Main(string[] args)
        {
            //create object of both classes
            ClassOne objOne = new ClassOne();
            ClassTwo objTwo = new ClassTwo();

            //call on the MyMethod method for each
            public static void MyMethod(object myObject)
            {
                IClass.myObject.MyString();
            }

            //call my method
            MyMethod(objOne);
            MyMethod(objTwo);


        }
    }
}
