using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class Sale
        {
        private List<SaleLine> saleLines;
        private double totalPrice;
        public Sale()
            {
            
            }
        public Sale(List<SaleLine> saleLines)
            {
            SaleLines = saleLines;
            }

        public List<SaleLine> SaleLines
            {
            get
                {
                return saleLines;
                
                }
            set
                {
                saleLines = value;
                }
            }

        public double TotalPrice
            {
            get
                {
                foreach (SaleLine saleLine in SaleLines)
                    {
                    TotalPrice += saleLine.TotalPrice;
                    }
                return totalPrice;
                }

            private set
                {
                totalPrice = value;
                }
            }

        private void addSaleLine(SaleLine item)
            {
                SaleLines.Add(item);
            }
        
        }
}
