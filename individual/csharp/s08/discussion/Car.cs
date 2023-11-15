using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{

    //[SECTION] Nested Types/ Nested Classes
        // A nested type is defined within a class, struct, or interface
        // This feature enables the user to logically group classes that are only used in one place, thus this increase the use of encapsulation, and create more readable and maintainable code.
        // Nested type classes, can be public, protected, internal, protected internal, private or private protected.
    internal class Car
    {
        private string make;
        private string model;

        public Car() { }
        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }

        // By default, a nested type's access specifier is set to provide when it's not declared.
        public class Engine
        {
            private string model;
            private int horsePower;
            private int cylinders;

            public Engine() { }
            public Engine(string model, int horsePower, int cylinders)
            {
                this.Model = model;
                this.HorsePower = horsePower;
                this.Cylinders = cylinders;
            }

            public string Model { get => model; set => model = value; }
            public int HorsePower { get => horsePower; set => horsePower = value; }
            public int Cylinders { get => cylinders; set => cylinders = value; }

            public void StartEngine()
            {
                Console.WriteLine("Engine is now running.");
            }

            public void StopEngine()
            {
                Console.WriteLine("Engine has been stopped.");
            }
        }

        public class Tires
        {
            private int pressure;
            private int size;
            private string brand;

            public Tires() { }
            public Tires(int pressure, int size, string brand)
            {
                this.Pressure = pressure;
                this.Size = size;
                this.Brand = brand;
            }

            public int Pressure { get => pressure; set => pressure = value; }
            public int Size { get => size; set => size = value; }
            public string Brand { get => brand; set => brand = value; }

            public void CheckPressure()
            {
                Console.WriteLine($"Tire pressure is at {pressure}.");
            }


        }
    }

}
