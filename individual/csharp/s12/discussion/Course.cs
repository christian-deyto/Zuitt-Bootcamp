using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Author { get; set; } = null!;

        public Course(int id, string name, decimal price, string author)
        {
            Id = id;
            Name = name;
            Price = price;
            Author = author;
        }
    }
}
