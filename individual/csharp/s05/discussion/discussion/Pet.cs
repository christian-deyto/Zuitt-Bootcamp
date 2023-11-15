using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Pet
    {

        //Fields/ Properties
        private string name;
        private string gender;
        private string classification;
        private int age;
        private string address;
        private string sound;

        //Constructor
        public Pet() { }

        public Pet(string name, string gender, string classification, int age, string address, string sound)
        {
            this.name = name;
            this.gender = gender;
            this.classification = classification;
            this.age = age;
            this.address = address;
            this.sound = sound;
        }


        //Destructor/Finalizers
        // A destructor is a special member function of a class that is executed whenever an object of its class goes out of the scope.
        // It has exactly the same name as that of the class with a prefixed tilde(~) and it can neither return a value  nor can it take any parameters.
        //Destructors can be very useful for releasing memory resources before exiting the program.
        // They cannot be inheriter or overloaded.
        // It is called when the program exits.
        ~Pet()
        {
            Console.WriteLine($"{name} is being deleted");
        }



        // Getters and Setters
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Classification { get => classification; set => classification = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string Sound { get => sound; set => sound = value; }


        // Action Methods

        public void DescribePet()
        {
            Console.WriteLine($"{name} is a {gender} {classification} who is {age} years of age and lives in {address}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

    }
}
