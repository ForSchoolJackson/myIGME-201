using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM2_DrawApp
{
    //digital art interface
    public interface IDigital
    {
        //methods
        void StartDraw();
        void FinishDraw();
        void ComputerOn();
    }

    //traditional art interface
    public interface ITraditional
    {
        //methods
        void StartDraw();
        void FinishDraw();
        void GetPaper();
        void UsePaint();
    }

    //abstract draw class
    public abstract class Draw
    {
        //feild
        private string description;

        //prperty
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        //virtual method
        public virtual void StartDraw()
        {
            Console.WriteLine("You start to draw.");
        }

        //abstract method
        public abstract void FinishDraw();
        


    }

    //child digital art class
    public class DigitalDraw:Draw, IDigital
    {
        //ovveride methods
        public override void StartDraw()
        {
            Console.WriteLine("You start to draw on the computer.");
        }
        public override void FinishDraw()
        {
            Console.WriteLine("After many hours hunched over the computer, your digital artwork is complete.");
        }

        //other method from interface
        public void ComputerOn()
        {
            Console.WriteLine("You turn the computer on.");
        }
    }

    //child traditional art class
    public class TraditionalDraw : Draw, ITraditional
    {
        //ovveride methods
        public override void StartDraw()
        {
            Console.WriteLine("You start to paint on the paper.");
        }
        public override void FinishDraw()
        {
            Console.WriteLine("After your tireless work, you have created a beautiful painting.");
        }

        //other methods from interface
        public void GetPaper()
        {
            Console.WriteLine("You get the paper out of the desk.");
        }
        public void UsePaint()
        {
            Console.WriteLine("You use the paint and get a little messy.");
        }

    }

    //program class
    internal class Program
    {
        static void Main(string[] args)
        {
            //create objects of child classes
            DigitalDraw myDigital = new DigitalDraw();
            TraditionalDraw myTraditional = new TraditionalDraw();

            //call methods
            DoArt(myDigital);
            DoArt(myTraditional);

        }

        static void DoArt(object obj)
        {
            //use parent class
            Draw art = (Draw)obj;

            Console.WriteLine(" ");

            //call the interface methods based on type
            if(art.GetType() == typeof(DigitalDraw))
            {
                //use interface to call method
                IDigital digi = (IDigital)art;
                digi.ComputerOn();

            }
            if (art.GetType() == typeof(TraditionalDraw))
            {
                //use interface to call methods
                ITraditional tradition = (ITraditional)art;
                tradition.GetPaper();
                tradition.UsePaint();

            }

            //call the parent methods
            art.StartDraw();
            art.FinishDraw();
        }
    }
}
