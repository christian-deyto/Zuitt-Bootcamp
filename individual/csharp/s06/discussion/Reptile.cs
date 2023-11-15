using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Reptile  : Animal
    {
        private string habitat;
        private bool hasScales;

        public Reptile() { }
        public Reptile(string habitat, bool hasScales)
        {
            this.Habitat = habitat;
            this.HasScales = hasScales;
        }

        public string Habitat { get => habitat; set => habitat = value; }
        public bool HasScales { get => hasScales; set => hasScales = value; }



        public void Eat()
        {
            Console.WriteLine("This animal is eating.");
        }



    }
}
