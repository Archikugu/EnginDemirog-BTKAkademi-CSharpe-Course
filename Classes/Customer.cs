using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        //field
        //public string FirstName;

        //Property
        public int CustomerId { get; set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        //Auto Property
        //public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
