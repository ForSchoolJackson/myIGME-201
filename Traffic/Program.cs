using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{

    //program class
    //jackson heim
    internal class Program
    {

        //using the vehicles lib create a function
        static void Main(string[] args)
        {

            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new PassengerTrain());
            AddPassenger(new Pickup());
            
        }

        static void AddPassenger(IPassengerCarrier Vehicle)
        {
            Console.WriteLine(Vehicle.ToString());
        }


           
        }

        //function to add passengers to 
        public void AddPassenger(Vehicle vehicleObject)
        {
            //vehicleObject.LoadPassenger();
            Console.WriteLine(vehicleObject.ToString());
        }

    }

}
