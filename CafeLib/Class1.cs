using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    //class library for cafe
    //jackson heim
    public class Class1
    {
        //take oder interface
        public interface ITakeOrder
        {
            //method
            void TakeOrder();

        }

        //customer/waiter mood interface
        public interface IMood
        {
            //property
            string Mood
            {
                get;
            }
        }

        //hot drink abstract class
        public abstract class HotDrink
        {
            //feilds
            public bool instant;
            public bool milk;
            private byte sugar;
            public string size;
            public Customer customer;

            //methods
            public virtual void AddSugar(byte amount)
            {

            }
            
            public abstract void Steam();

            //constructors
            public HotDrink()
            {

            }
            public HotDrink(string brand)
            {

            }

        }

        //Waiter class
        public class Waiter: IMood
        {
            //feild
            public string name;

            //mood property
            public string Mood
            {
                get;
            }

            //method
            public void ServeCustomer(HotDrink cup)
            {

            }

        }

        //Customer class
        public class Customer: IMood
        {
            //feilds
            public string name;
            public string creditCardNumber;

            //mood property
            public string Mood
            {
                get;
            }
        }

        //coffee cup class
        public class CupOfCoffee : HotDrink, ITakeOrder
        {
            //feild
            public string beanType;

            //methods
            public override void Steam()
            {

            }
            public void TakeOrder()
            {

            }

            //constructor
            public CupOfCoffee(string brand): base(brand)
            {

            }
        }

        //tea cup class
        public class CupOfTea : HotDrink, ITakeOrder
        {
            //feild
            public string leafType;

            //methods
            public override void Steam()
            {

            }
            public void TakeOrder()
            {

            }

            //constructor
            public CupOfTea(bool customerIsWealthy)
            {

            }
        }

        //cocoa cup class
        public class CupOfCocoa : HotDrink, ITakeOrder
        {
            //feilds
            public static int numCups;
            public bool marshmallows;
            private string source;

            //property
            public string Source
            {
                set
                {

                }
            }

            //methods
            public override void Steam()
            {

            }
            public override void AddSugar(byte amount)
            {
                
            }
            public void TakeOrder()
            {

            }

            //constructor
            public CupOfCocoa(): this(false)
            {

            }
            public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
            {

            }
        }

    }
}
