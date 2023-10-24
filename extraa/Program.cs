using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraa
{
    public class Program
    {
        public class MyClass
        {
            public string words = "this is the sentance of hope";
            public int numb;

            public MyClass(int num)
            {
                this.numb = num;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        static void Main()
        {
            MyClass objectA = new MyClass(7);
           
            MyClass objectB = (MyClass)objectA.Clone();
          
            objectA = new MyClass(15);


            Console.WriteLine(objectA.words);
            Console.WriteLine(objectA.numb);

            Console.WriteLine(objectB.words);
            Console.WriteLine(objectB.numb);


            Console.WriteLine(" ");





            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();

            friendBirthdays.Add("James", new DateTime(2004, 11, 3));
            friendBirthdays.Add("Bennett", new DateTime(2007, 2, 28));
            friendBirthdays.Add("Hope", new DateTime(2015, 6, 8));

            // where string = friend's name and DateTime = their birthdate
            // (use the format string "MM/dd/yyyy" in your output)

            foreach (var day in friendBirthdays)
            {
                Console.WriteLine(day.Key+"'s birthday is " + day.Value.ToString("MMMM dd, yyyy") + ".");
            }


        }
    }
}
