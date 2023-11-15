using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Animal
    {
        private string classification;
        private string dietType;

        public Animal() { }

        public Animal(string classification, string dietType)
        {
            this.Classification = classification;
            this.DietType = dietType;
        }

        public string Classification { get => classification; set => classification = value; }
        public string DietType { get => dietType; set => dietType = value; }

        public void Sleep()
        {
            Console.WriteLine("This animal is sleeping. ");
        }
    }
}
