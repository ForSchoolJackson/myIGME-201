using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //abstract pet class
    public abstract class Pet
    {
        //feilds
        private string name;
        public int age;

        //methods

        //constructor
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    //cats interface
    public interface iCat
    {
        //methods

    }

    //dogs interface
    public interface iDog
    {

    }

    //pets class
    public class Pets
    {
        //list of pets
        public List<Pet> petList = new List<Pet>();

        //methods
        
    }
    
    





    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
