using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class SaleLine
    {
        private Product product;
        private string itemDescription;
        private double pricePerPiece;
        private int qty;
        private double totalPrice;


        
        //public SaleLine(string itemDescription, double pricePerPiece, int qty)
        //    {
        //        ItemDescription = itemDescription;
        //        PricePerPiece = pricePerPiece;
        //        Qty = qty;
        //        TotalPrice = PricePerPiece * Qty;
        //    }
        public SaleLine(Product product, int qty)
            {
            Product = product;
            ItemDescription = product.Description;
            PricePerPiece = product.Price;
            Qty = qty;
            TotalPrice = PricePerPiece * Qty;

            }

        public string ItemDescription
            {
            get
                {
                return itemDescription;
                }

            set
                {
                itemDescription = value;
                }
            }

        public double PricePerPiece
            {
            get
                {
                return pricePerPiece;
                }

            set
                {
                pricePerPiece = value;
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

        public double TotalPrice
            {
            get
                {
                return totalPrice;
                }

            private set
                {
                totalPrice = value;
                }
            }

        public Product Product
            {
            get
                {
                return product;
                }

            set
                {
                product = value;
                }
            }
        }
}
