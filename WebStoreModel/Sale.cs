using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class Sale
    {
        public Sale(int id, SaleLine saleLine, double totalPrice, DateTime createdDate)
        {
            this.id = id;
            this.saleLine = saleLine;
            this.totalPrice = totalPrice;
            this.createdDate = createdDate;
        }

        public Sale()
        {
            this.id = 0;
            this.saleLine = null;
            this.totalPrice = 0;
            this.createdDate = default(DateTime);
        }

        public int id { get; set; }
        public SaleLine saleLine { get; set; }
        public double totalPrice { get; set; }
        public DateTime createdDate { get; set; }
    }
}
