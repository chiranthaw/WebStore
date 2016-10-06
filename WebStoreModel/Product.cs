using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class Product
    {
        private string brand;
        private string colour;
        private string description;
        private double price;
        private int qty;
        private string size;
        private string type;

        public Product()
            {}
        public Product(string description, string brand, string type, string colour, string size, int qty, double price)
            {
            Description = description;
            Brand = brand;
            Type = type;
            Colour = colour;
            Size = size;
            Qty = qty;
            Price = price;
            }

        public string Brand
            {
            get
                {
                return brand;
                }

            set
                {
                brand = value;
                }
            }

        public string Colour
            {
            get
                {
                return colour;
                }

            set
                {
                colour = value;
                }
            }

        public string Description
            {
            get
                {
                return description;
                }

            set
                {
                description = value;
                }
            }

        public double Price
            {
            get
                {
                return price;
                }

            set
                {
                price = value;
                }
            }

        public int Qty
            {
            get
                {
                return qty;
                }

            set
                {
                qty = value;
                }
            }

        public string Size
            {
            get
                {
                return size;
                }

            set
                {
                size = value;
                }
            }

        public string Type
            {
            get
                {
                return type;
                }

            set
                {
                type = value;
                }
            }
        }
}
