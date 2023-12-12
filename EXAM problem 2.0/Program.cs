using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_problem_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();

            //enqueue int
            myQueue.Enqueue(1);
            myQueue.Enqueue(5);
            myQueue.Enqueue(9);
            myQueue.Enqueue(10);
            myQueue.Enqueue(13);
            myQueue.Enqueue(12);
            myQueue.Enqueue(8);
            myQueue.Enqueue(2);

            //show queue
            Console.WriteLine(myQueue.ToString());

            //dequeue 
            myQueue.Dequeue();
            Console.WriteLine(myQueue.ToString());

            //show the peek
            Console.WriteLine(myQueue.Peek());

        }
    }

    public class MyQueue
    {
        //create stack using list
        List<int> queue;
        public MyQueue()
        {
            this.queue = new List<int>();
        }

        //enqueue
        public void Enqueue(int n)
        {
            this.queue.Add(n);

        }

        //dequeue
        public int Dequeue()
        {
            int num = 0;
            num = this.queue[0];
            this.queue.RemoveAt(0);

            return num;

        }

        //peek
        public int Peek()
        {
            int num = 0;
            num = this.queue[0];

            return num;
        }


        //ovviride the ToString method because it dies not work
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = queue.Count - 1; i >= 0; i--)
            {
                sb.AppendLine(queue[i].ToString());
            }
            return sb.ToString();
        }


    }
}
