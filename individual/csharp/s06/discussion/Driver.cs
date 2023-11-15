using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Driver
    {
        private string name;
        private int age;

        public Driver() { }
        public Driver(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
