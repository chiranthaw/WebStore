using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class Supplier
        {
        private string name;
        private string address;
        private string phoNo;
        private string email;


        public string Name
            {
            get
                {
                return name;
                }

            set
                {
                name = value;
                }
            }

        public string Address
            {
            get
                {
                return address;
                }

            set
                {
                address = value;
                }
            }

        public string PhoNo
            {
            get
                {
                return phoNo;
                }

            set
                {
                phoNo = value;
                }
            }

        public string Email
            {
            get
                {
                return email;
                }

            set
                {
                email = value;
                }
            }
        public Supplier()
            {
            ;
            }
        public Supplier(string name, string address, string phoNo, string email)
            {
            Name = name;
            Address = address;
            PhoNo = phoNo;
            Email = email;
            
            }

        }
}
