using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra
{
    static class Program
    {


        static void Main()
        {
            //initialize w x y z
            double w = 0;
            double x = 0;
            double y = 0;
            double z = 0;

            //intervals of w x y
            int nW = 0;
            int nX = 0;
            int nY = 0;

            //Sorted list where tuple for w x y is the index key
            SortedList<(double, double, double), double> calculation = new SortedList<(double, double, double), double>();

            //incriment though w
            for (w = -2; w <= 0; w += 0.2, nW++)
            {
                //round because of doubles
                w = Math.Round(w, 1);

                //y interval should start at 0
                nY = 0;

                //inriment through y
                for (y = -1; y <= 1; y += 0.1, nY++)
                {
                    //round because of doubles
                    y = Math.Round(y, 1);

                    //the x interval should start at 0
                    nX = 0;

                    //incriment though x
                    for (x = 0; x <= 4; x += 0.1, nX++)
                    {
                        //round because of doubles
                        x = Math.Round(x, 1);

                        //calculate z
                        z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * w + 7;
                        //round z three decimal places
                        z = Math.Round(z, 3);

                        //test
                        Console.WriteLine(w +" "+ x + " " + y + " " + z);

                        //add to the list
                        calculation.Add((w,x,y), z);
                    }


                }
            }


        }
    }
}
