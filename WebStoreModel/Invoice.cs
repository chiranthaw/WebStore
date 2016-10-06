using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class Invoice
    {
        private string customerName;
        private string customerAddress;
        private string customerPhoNo;
        private List<Product> items;
        private double shippingPrice;
        private double totalPrice;
        private double discount;

        public string CustomerName
            {
            get
                {
                return customerName;
                }

            set
                {
                customerName = value;
                }
            }

        public string CustomerAddress
            {
            get
                {
                return customerAddress;
                }

            set
                {
                customerAddress = value;
                }
            }

        public string CustomerPhoNo
            {
            get
                {
                return customerPhoNo;
                }

            set
                {
                customerPhoNo = value;
                }
            }

        public List<Product> Items
            {
            get
                {
                return items;
                }

            set
                {
                items = value;
                }
            }

        public double ShippingPrice
            {
            get
                {
                return shippingPrice;
                }

            set
                {
                shippingPrice = value;
                }
            }

        public double TotalPrice
            {
            get
                {
                return totalPrice;
                }

            set
                {
                totalPrice = value;
                }
            }

        public double Discount
            {
            get
                {
                return discount;
                }

            set
                {
                discount = value;
                }
            }

        public Invoice(User user, Sale sale)
            {
            CustomerName = user.FirstName + user.LastName;
            CustomerAddress = user.Address;
            CustomerPhoNo = user.PhoNo;
            foreach (SaleLine saleLine in sale.SaleLines)
                {
                items.Add(saleLine.Product);
                }
            TotalPrice = sale.TotalPrice * ( 1 - Discount ) + ShippingPrice;
            }
        public override string ToString()
            {
            String result = String.Format("Customer name: {0} /n Customer address: {1} /n Customer phone number: {2} /n Items: /n", CustomerName, CustomerAddress, CustomerPhoNo);
            foreach (Product item in Items)
                result = result + item.Description + "/n";
            result = result + "Total price: " + TotalPrice;
            return result;
            }
        }
}
