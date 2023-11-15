using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Casio : ICalculator
    {

        private string brand;
        private string price;


        public Casio() { }
        public Casio(string brand, string price)
        {
            this.brand = brand;
            this.price = price;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Price { get => price; set => price = value; }

        public void Compute(double numA, double numB, String operation)
        {
            if(operation.Equals("add", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(numA + numB);
            }
            else if (operation.Equals("subtract", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(numA - numB);
            }
            else if (operation.Equals("multiply", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(numA * numB);
            }
            else if (operation.Equals("divide", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(numA / numB);
            }
            else
            {
                Console.WriteLine("Invalid number or operation provided.");
            }
        }

        public void TurnOff()
        {
            Console.WriteLine($"Closing {brand} calculator");
        }



    }
}
