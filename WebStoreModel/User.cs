using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreModel
{
    public class User
    {
        public User(int id, string firstName, string lastName, string email, string password, string address, string mobile, ZipCode zipCode)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.address = address;
            this.mobile = mobile;
            this.zipCode = zipCode;
        }

        public User()
        {
            this.id = 0;
            this.firstName = "";
            this.lastName = "";
            this.email = "";
            this.password = "";
            this.address = "";
            this.mobile = "";
            this.zipCode = null;
        }

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public ZipCode zipCode { get; set; }
    }
}
