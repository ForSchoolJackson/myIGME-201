using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_ONE_8
{
    //program class
    //jackson heim
    internal class Program
    {

        //define delegate
        delegate double RoundNumber(double num, int roundTo);


        //using formula 4y^3 + 2x^2 - 8x + 7
        //store z for different ranges of x and y
        static void Main(string[] args)
        {

            //declare delegate method variable
            RoundNumber myRoundNumber;

            //point the vairbale to the method to call
            myRoundNumber = new RoundNumber(Round);


            //initailize x y z
            double x = 0;
            double y = 0;
            double z = 0;

            //intervals of x and y
            int nX = 0;
            int nY = 0;

            //use 3 dimentional array
            //for y = -1 through 1 inriments of 0.1; there are 21
            //for x = 0 through 4 incrimints of 0.1; there are 41
            double[,,] calculation = new double[41, 21, 3];

            //incriment though x
            for (x = 0; x <= 4; x += 0.1, nX++)
            {
                //round because of doubles
                x = myRoundNumber(x, 1);

                //y interval should start at 0
                nY = 0;

                //inriment through y
                for (y = -1; y <= 1; y += 0.1, nY++)
                {
                    //round because of doubles
                    y = myRoundNumber(y, 2);

                    //calculate z
                    z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * x + 7;
                    //round z three decimal places
                    z = myRoundNumber(z, 3);


                    //store z into the array
                    calculation[nX, nY, 2] = z;


                   

                }


            }

            //test
            Console.WriteLine(calculation[0, 0, 2]);
        }

        static double Round(double num, int roundTo)
        {
            //round the numbers
            if (roundTo == 1)
            {
                //round to 1 decimal
                num = Math.Round(num, 1);
            }
            else if (roundTo == 3)
            {
                //round to 2 decimals
                num = Math.Round(num, 3);
            }

            //retrun the number
            return num;
        }

    }
}
