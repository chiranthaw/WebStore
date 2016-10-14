using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class SaleLine
    {
        public SaleLine(int id, Product product, int qty, double price)
        {
            this.id = id;
            this.product = product;
            this.qty = qty;
            this.price = price;
        }

        public SaleLine()
        {
            this.id = 0;
            this.product = null;
            this.qty = 0;
            this.price = 0;
        }

        public int id { get; set; }
        public Product product { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
    }
}
