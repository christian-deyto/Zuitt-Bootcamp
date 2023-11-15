﻿namespace ECommerceCapstone.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public bool Archived { get; set; }
        public int Quantity { get; set; }
    }
}
