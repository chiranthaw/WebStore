using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class ZipCode
    {
        public ZipCode(int id, string zipCode)
        {
            this.id = id;
            this.zipCode = zipCode;
        }

        public ZipCode()
        {
            this.id = 0;
            this.zipCode = "";
        }

        public int id { get; set; }
        public string zipCode { get; set; }

        
    }
}
