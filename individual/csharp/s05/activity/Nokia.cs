using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class Nokia : ICellphone
    {
        private string model;
        private int price;
        private string supplier;

        public Nokia() { }
        public Nokia(string model, int price, string supplier)
        {
            this.Model = model;
            this.Price = price;
            this.Supplier = supplier;
        }

        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
        public string Supplier { get => supplier; set => supplier = value; }

        public void SendText(string message, string recipient)
        {
            Console.WriteLine($"Text message sent to: {recipient}");
            Console.WriteLine(message);
        }

        public void PlayMusic(string songName)
        {
            Console.WriteLine($"The song {songName} is playing.");
        }
    }
}
