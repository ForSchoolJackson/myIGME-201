using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    public interface IClass
    {
        void MyMethod(object MyObject);
    }

    public class ClassOne: IClass
    {
        public void MyMethod(object myObject)
        {
            Console.WriteLine(myObject);
        }
    }

    public class ClassTwo : IClass
    {
        public void MyMethod(object myObject)
        {
            Console.WriteLine(myObject);
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
            objOne.MyMethod(objOne);
            objTwo.MyMethod(objTwo);

        }
    }
}
