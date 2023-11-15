using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class House
    {

        private string type;
        private string address;

        public House() { }

        public House(string type, string address)
        {
            this.Type = type;
            this.Address = address;
        }

        public string Type { get => type; set => type = value; }
        public string Address { get => address; set => address = value; }

        public void DisplayHouse()
        {
            Console.WriteLine(Type);
            Console.WriteLine(Address);
        }


        public class Bedroom
        {
            private string bed;
            private ArrayList furnitures = new ArrayList();

            public Bedroom() { }

            public Bedroom(string bed)
            {
                this.Bed = bed;
            }

            public string Bed { get => bed; set => bed = value; }

            public void AddFurniture(string furniture)
            {
                furnitures.Add(furniture);
                Console.WriteLine($"{furniture} has been successfully added");
            }

            public void DisplayBed()
            {
                Console.WriteLine(Bed);
            }
            public void DisplayFurniture()
            {
                Console.WriteLine("The bedroom has the following furnitures:");
                foreach (var furniture in furnitures)
                {
                    Console.WriteLine(furniture);
                }
            }
        }

        public class Bathroom
        {
            private bool hasShower;
            private bool hasBathTub;

            public Bathroom(bool hasShower, bool hasBathTub)
            {
                this.hasShower = hasShower;
                this.hasBathTub = hasBathTub;
            }

            public bool HasShower { get => hasShower; set => hasShower = value; }
            public bool HasBathTub { get => hasBathTub; set => hasBathTub = value; }

            public void isOpenShower()
            {
                Console.WriteLine("The shower is currently running");
            }
        }
    }
}
