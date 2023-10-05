using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{

    public interface IPassengerCarrier
    {
     
    }

    public interface IHeavyLoadCarrier
    {

    }

    public abstract class Vehicle
    {
    }

    public abstract class Train : Vehicle
    {

    }

    public abstract class Car : Vehicle
    {

    }

    public class PassengerTrain : Train, IPassengerCarrier
    {

    }

    public class FreightTrain : Train
    {

    }

    public class _424DoubleBougey : Train
    {

    }

    public class Compact : Car , IPassengerCarrier
    {

    }

    public class Pickup : Car , IHeavyLoadCarrier,IPassengerCarrier
    {

    }

    public class SUV : Car, IPassengerCarrier
    {

    }

 

}
