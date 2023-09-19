using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memorygame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ascendingNumbers = new int[5];
            for (int i = 0; i < ascendingNumbers.Length; i++)
            {
                ascendingNumbers[i] += (i + 1);
            }

            cobsole.WriteLine(ascendingNumbers);
        }
    }
}
