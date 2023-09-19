using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_5
{
    //jackson heim
    //program class
    internal class Program
    {
        //using formula z = 3y^2 + 2x - 1
        //calculate z for different ranges of x and y
        static void Main(string[] args)
        {

            //initailize x y z
            double x = 0;
            double y = 0;
            double z = 0;

            //intervals of x and y
            int nX = 0;
            int nY = 0;


            //use 3 dimentional array
            //for x = -1 through 1 inriments of 0.1; there are 22
            //for y = 1 through 4 incrimints of 0.1; there are 31
            double[,,] calculation = new double [22, 31, 3];

            //incriment though x
            for (x = -1; x <= 1; x += 0.1,nX++)
            {
                //round because of doubles
                x = Math.Round(x, 1);

                //y interval should start at 0
                nY = 0;

                //inriment through y
                for (y = 1; y <= 4; y += 0.1, nY++)
                {
                    //round because of doubles
                    y = Math.Round(y, 1);

                    //calculate z
                    z = 3 * Math.Pow(y, 2) + 2 + 2 * x - 1;
                    //round z three decimal places
                    z = Math.Round(z, 3);



                    //use array
                    calculation[nX, nY, 0] = x;
                    calculation[nX, nY, 1] = y;
                    calculation[nX, nY, 2] = z;

                    //find z
                    Console.WriteLine(calculation[nX, nY, 2]);

                
                }



            }



        }
    }
    
}
