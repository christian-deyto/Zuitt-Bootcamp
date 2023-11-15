using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Car
    {
        private string make;
        private string model;
        private Driver driver;

        public Car() { }
        public Car(string make, string model, Driver driver)
        {
            this.Make = make;
            this.Model = model;
            this.Driver = driver;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        internal Driver Driver { get => driver; set => driver = value; }

        public void StartEngine()
        {
            Console.WriteLine("The car engine is now running.");
        }

    }
}
