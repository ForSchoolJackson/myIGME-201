using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//vehicle library
//jackson heim
namespace Vehicles
{

    //passanger carry interface
    public interface IPassengerCarrier
    {
        

    }

    //heavy load carry interface
    public interface IHeavyLoadCarrier
    {

    }

    //parent vehicle class
    public abstract class Vehicle
    {
        public virtual void LoadPassenger() { }

    }

    //parent train class, child of vehicle
    public abstract class Train : Vehicle
    {
        
    }

    //parent car class, child of vehicle
    public abstract class Car : Vehicle
    {

    }

    //child passenger train class
    public class PassengerTrain : Train, IPassengerCarrier
    {

    }

    //child freight train class
    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    //child 424 double bougy class
    public class _424DoubleBougey : Train
    {

    }

    //child compact class
    public class Compact : Car , IPassengerCarrier
    {

    }

    //child pickup classs
    public class Pickup : Car , IHeavyLoadCarrier,IPassengerCarrier
    {

    }

    //child suv class
    public class SUV : Car, IPassengerCarrier
    {

    }



}
