using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{

    //cats interface
    public interface ICat
    {
        //methods
        void Eat();
        void Play();
        void Scratch();
        void Purr();

    }

    //dogs interface
    public interface IDog
    {
        //methods
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }
    

    //abstract pet class
    public abstract class Pet
    {
        //feilds
        private string name;
        public int age;

        //property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //methods
        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

        //constructors
        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }

    //pets class
    public class Pets
    {
        //list of pets
        public List<Pet> petList = new List<Pet>();

        //properties
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        //methods
        public void Add(Pet pet )
        {
            petList.Add(pet);
        }
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }

    }

    //cat child class
    public class Cat: Pet, ICat
    {
        //override methods
        public override void Eat()
        {
            Console.WriteLine(Name+" is starving and wants some food.");
        }
        public override void Play()
        {
            Console.WriteLine(Name + " wants to play");
        }
        public override void GotoVet()
        {
            Console.WriteLine(Name + " is feeling sick, you might need to go to the vet.");
        }
        //methods
        public void Purr()
        {
            Console.WriteLine(Name + " is purring on your lap.");
        }
        public void Scratch()
        {
            Console.WriteLine(Name + " is trying to scratch out your eyes.");
        }


        //defult constructor
        public Cat()
        {

        }

    }

    //child dog class
    public class Dog: Pet, IDog
    {
        //feild
        public string license;

        //ovrride methods
        public override void Eat()
        {
            Console.WriteLine(Name + " is starving and wants some food.");
        }
        public override void Play()
        {
            Console.WriteLine(Name + " wants to play");
        }
        public override void GotoVet()
        {
            Console.WriteLine(Name + " is feeling sick, you might need to go to the vet.");
        }
        //methods
        public void Bark()
        {
            Console.WriteLine(Name + " is barking very loudly");
        }
        public void NeedWalk()
        {
            Console.WriteLine(Name + " is waiting at the door for a walk.");
        }

        //constructors
        public Dog(string license, string szName, int nAge): base(szName, nAge)
        {
            this.license = license;
        }



    }


    //program class
    internal class Program
    {
        //main function
        static void Main(string[] args)
        {
            //reference varibales
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            //list of pets
            Pets pets = new Pets();

            //random number generator
            Random rand = new Random();

            //iterate 50 times
            for(int i =0; i < 50; i++)
            {
                // Console.WriteLine(i);-----test if 50 times

                //genberate random number 1 to 10
                //if 1 add an animal
                if (rand.Next(1, 11) == 1)
                {
                    //50/50 between cats and dogs
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");
                        // add a dog
                        pets.Add(dog);

                        //promt user for feilds
                        Console.Write("Dogs Name: ");
                        thisPet.Name = Console.ReadLine();
                        Console.Write("Age: ");
                        thisPet.age = Console.ReadLine();
                        Console.Write("License: ");
                        dog.license = Console.ReadLine();

                    }
                    else
                    {
                        // else add a cat
                        pets.Add(cat);

                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                }
            }

        }
    }
}
