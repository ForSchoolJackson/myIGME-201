using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace EXAM2_PhoneApp
{

    //Phone interface
    public interface PhoneInterface
    {
        //methods
        void Answer();
        void MakeCall();
        void HangUp();
    }

    //Abstract phone class
    public abstract class Phone
    {
        //feilds
        private string phoneNumber;
        public string address;

        //property
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        //methods
        public abstract void Connect();
        public abstract void Disconnect();
    }

    //rotary phone class
    public class RotaryPhone: Phone, PhoneInterface
    {
        //methods
        public void Answer()
        {
            
        }
        public void MakeCall()
        {
            //testing
            Console.WriteLine("calling from a rotary phone");
        }
        public void HangUp()
        {
            //testing
            Console.WriteLine("hanging up the rotary phone");
        }


        //override methods
        public override void Connect()
        {
           
        }
        public override void Disconnect()
        {
            
        }
    }


    // button phone class
    public class PushButtonPhone : Phone, PhoneInterface
    {
        //methods
        public void Answer()
        {

        }
        public void MakeCall()
        {
            //testing
            Console.WriteLine("calling from a push button phone");
        }
        public void HangUp()
        {
            //testing
            Console.WriteLine("hanging up the push button phone");
        }


        //override methods
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    //child tardis class
    public class Tardis: RotaryPhone
    {
        //feilds
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        //properties
        public byte WhichDrWho
        {
            get
            {
                return this.whichDrWho;
            }
        }
        //bollean operators to compare Tardis objects
        public static bool operator ==(Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10 && dr2.whichDrWho != 10)
            {
                return (dr1.whichDrWho > dr2.whichDrWho);
            }
            else if(dr2.whichDrWho == 10 && dr1.whichDrWho != 10){
                return (dr1.whichDrWho < dr2.whichDrWho);
            }
            else
            {
                return (dr1.whichDrWho == dr2.whichDrWho);
            }
        }
        public static bool operator !=(Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10 && dr2.whichDrWho != 10)
            {
                return (dr1.whichDrWho > dr2.whichDrWho);
            }
            else if (dr2.whichDrWho == 10 && dr1.whichDrWho != 10)
            {
                return (dr1.whichDrWho < dr2.whichDrWho);
            }
            else
            {
                return (dr1.whichDrWho != dr2.whichDrWho);
            }
            
        }
        public static bool operator <(Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10 && dr2.whichDrWho != 10)
            {
                return (dr1.whichDrWho > dr2.whichDrWho);
            }
            else if (dr2.whichDrWho == 10 && dr1.whichDrWho != 10)
            {
                return (dr1.whichDrWho < dr2.whichDrWho);
            }
            else
            {
                return (dr1.whichDrWho < dr2.whichDrWho);
            }
            
        }
        public static bool operator >(Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10 && dr2.whichDrWho != 10)
            {
                return (dr1.whichDrWho > dr2.whichDrWho);
            }
            else if (dr2.whichDrWho == 10 && dr1.whichDrWho != 10)
            {
                return (dr1.whichDrWho < dr2.whichDrWho);
            }
            else
            {
                return (dr1.whichDrWho > dr2.whichDrWho);
            }
            
        }
        public static bool operator <=(Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10 && dr2.whichDrWho != 10)
            {
                return (dr1.whichDrWho > dr2.whichDrWho);
            }
            else if (dr2.whichDrWho == 10 && dr1.whichDrWho != 10)
            {
                return (dr1.whichDrWho < dr2.whichDrWho);
            }
            else
            {
                return (dr1.whichDrWho <= dr2.whichDrWho);
            }
            
        }
        public static bool operator >=(Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10 && dr2.whichDrWho != 10)
            {
                return (dr1.whichDrWho > dr2.whichDrWho);
            }
            else if (dr2.whichDrWho == 10 && dr1.whichDrWho != 10)
            {
                return (dr1.whichDrWho < dr2.whichDrWho);
            }
            else
            {
                return (dr1.whichDrWho >= dr2.whichDrWho);
            }
            
        }

        public string FemaleSideKick
        {
            get
            {
                return this.femaleSideKick;
            }
        }

        //method
        public void TimeTravel()
        {
            //testing
            Console.WriteLine("Off we go on another adventure!");
        }
    }


    //child phone booth class
    public class PhoneBooth: PushButtonPhone
    {
        //feilds
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        //methods
        public void OpenDoor()
        {
            //testing
            Console.WriteLine("the door opens");
        }
        public void CloseDoor()
        {

        }
    }


    //program class
    internal class Program
    {
        static void Main(string[] args)
        {
 
            //create objects
            Tardis theTardis = new Tardis();
            PhoneBooth thePhoneBooth = new PhoneBooth();

            //pass though use phone method
            UsePhone(theTardis);
            UsePhone(thePhoneBooth);
        }

        //use phone method
        static void UsePhone(object obj)
        {
            //use interface methods
            PhoneInterface phone = (PhoneInterface)obj;

            //call the methods
            phone.MakeCall();
            phone.HangUp();

            //add open door if phone booth
            //add time travel if tardis
            if (phone.GetType() == typeof(PhoneBooth))
            {
                PhoneBooth booth = (PhoneBooth)phone;
                booth.OpenDoor();

            }
            if (phone.GetType() == typeof(Tardis))
            {
                Tardis booth = (Tardis)phone;
                booth.TimeTravel();

            }

            }
    }
}
