using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class Matrix
        {
            public Matrix()
            {
                //mkae list of edges
                List<string> vertices = new List<string> { "Red", "Green", "Blue", "Cyan", "Yellow", "Orange", "Purple", "Grey" };

                //matrix weights connecting edges
                Dictionary<(string, string), int> edges = new Dictionary<(string, string), int>
                {
                    {("Red", "Blue"), 1 },
                    {("Red", "Grey"), 5 },
                    {("Blue", "Cyan"), 1 },
                    {("Cyan", "Blue"), 1 },
                    {("Grey", "Cyan"), 0 },
                    {("Cyan", "Grey"), 0 },
                    {("Grey","Orange"), 1 },
                    {("Orange", "Purple"), 1 },
                    {("Purple", "Yellow"),1 },
                    {("Yellow", "Green"),6 }
                };
            }

        }
    }
}
