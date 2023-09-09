using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteFood = "spaghetti";
            switch (favoriteFood)
            {
                case ("spaghetti"):
                    Console.WriteLine("You seem to really like spaghetti");
                    break;
                case ("cake"):
                    Console.WriteLine("Wrong. Spaghetti is the best food.");
                    break;
                default:
                    Console.WriteLine("You should like spaghetti.");
                    break;
            }



        }
    }
}
