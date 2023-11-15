using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Turtle : Reptile
    {
        //[SECTION] Polymorphism
        // Polymorphism is derived from the Greek words "Poly" which means "many" and "Morph" which means "forms".
        // It is the abilty of an object to take many forms.

        private string name;
        private int age;

        public Turtle () { }
        public Turtle(string name, int age, string classification, string dietType, string habitat, bool hasScales)
        {
            this.name = name;
            this.age = age;
            Classification = classification;
            DietType = dietType;
            Habitat = habitat;
            HasScales = hasScales;

        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void Swim()
        {
            Console.WriteLine("This turtle is swimming using its limbs and webbed feet.");
        }

        //[SECTION] Static Polymorphism and Dynamic Polymorphism/Function Overloading
            // The mechanism of linking a function with an object during the compile time is called static/early binding.
            // The definition of the function must differ from each other by the types and/or the number of arguments in dynamic polymorphism.

        public void Swim(string location)
        {
            Console.WriteLine($"This turtle is swimming in the {location}");
        }

        // Dynamic Poly overloading by different value/data type
        public void Swim(int distance)
        {
            Console.WriteLine($"This turtle has swam a distance of {distance} meters.");
        }

        // Dynamic Poly overloading by different number or arguments
        public void Swim(string location, string action)
        {
            Console.WriteLine($"This turtle is {action} in the {location}");
        }
    }
}
