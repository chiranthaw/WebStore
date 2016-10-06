namespace WebStoreModel
    {
    public class User
        {
        private string address;
        private string email;
        private string firstName;
        private string lastName;
        private string phoNo;

        public User(string firstName, string lastName, string address, string email, string phoNo)
            {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            PhoNo = phoNo;
            }
        public User()
            {
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

        public string FirstName
            {
            get
                {
                return firstName;
                }

            set
                {
                firstName = value;
                }
            }

        public string LastName
            {
            get
                {
                return lastName;
                }

            set
                {
                lastName = value;
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
        }
    }