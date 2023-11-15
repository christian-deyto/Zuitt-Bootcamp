using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Crocodile : Reptile
    {
        private string name;
        private int age;

        public Crocodile() { }
        public Crocodile(string name, int age, string classification, string dietType, string habitat, bool hasScales)
        {
            this.Name = name;
            this.Age = age;
            Classification = classification;
            DietType = dietType;
            Habitat = habitat;
            HasScales = hasScales;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void Swim()
        {
            Console.WriteLine("This crocodile is swimming.");
        }

        public void DescribePet()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Classification: {Classification}");
            Console.WriteLine($"Diet Type: {DietType}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Has Scales: {HasScales}");
        }

    }
}
