using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class Invoice
    {
        public Invoice(int id, User user, Sale sale, double shippingPrice, double totalPrice, int status)
        {
            this.id = id;
            this.customer = user;
            this.sale = sale;
            this.shippingPrice = shippingPrice;
            this.totalPrice = totalPrice;
            this.status = status;
        }

        public Invoice()
        {
            this.id = 0;
            this.customer = null;
            this.sale = null;
            this.shippingPrice = 0;
            this.totalPrice = 0;
            this.status = 0;
        }

        public int id { get; set; }
        public User customer { get; set; }
        public Sale sale { get; set; }
        public double shippingPrice { get; set; }
        public double totalPrice { get; set; }
        public int status { get; set; }
    }
}
