using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            //push int
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(10);
            myStack.Push(13);
            myStack.Push(9);
            myStack.Push(7);
            myStack.Push(3);

            //show stack
            Console.WriteLine(myStack.ToString());

            //pop off the top int
            myStack.Pop();
            Console.WriteLine(myStack.ToString());

            //show top int on stack
            Console.WriteLine(myStack.Peek());

        }
    }

    public class MyStack
    {
        //create stack using list
        List<int> stack;
        public MyStack()
        {
          this.stack = new List<int>();
        }

        //push
        public void Push(int n)
        {
            this.stack.Add(n);

        }

        //pop
        public int Pop()
        {
            int num = 0;
            num= this.stack[this.stack.Count - 1];
            this.stack.RemoveAt(stack.Count - 1);

            return num;

        }

        //peek
        public int Peek()
        {
            int num = 0;
            num = this.stack[this.stack.Count - 1];

            return num;
        }

        //ovviride the ToString method because it dies not work
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                sb.AppendLine(stack[i].ToString());
            }
            return sb.ToString();
        }

    }
}
