using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class Product
    {
        public Product(int id, string description, string brand, string type, string colour, string size, double price)
        {
            this.id = id;
            this.description = description;
            this.brand = brand;
            this.type = type;
            this.colour = colour;
            this.size = size;
            this.price = price;
        }

        public Product()
        {
            this.id = 0;
            this.description = "";
            this.brand = "";
            this.type = "";
            this.colour = "";
            this.size = "";
            this.price = 0;
        }

        public int id { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public string colour { get; set; }
        public string size { get; set; }
        public double price { get; set; }

    }
}
