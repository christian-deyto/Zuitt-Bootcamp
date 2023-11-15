using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Honda : Car
    {
        private int price;

        public Honda() { }

        public Honda(int price, string model, string make)
        {
            this.Price = price;
            Model = model;
            Make = make;
        }

        public int Price { get => price; set => price = value; }
    }
}
