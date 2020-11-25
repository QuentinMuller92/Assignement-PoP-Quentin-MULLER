using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_PoP_MULLER
{
    public class Address
    {
        private int number;
        private string street;
        private string city;
        private string country;

        //Constructor
        public Address(int number, string street, string city, string country)
        {
            this.number = number;
            this.street = street;
            this.city = city;
            this.country = country;
        }

        //Properties
        public int Number
        {
            get { return this.number; }
            set
            {
                number = value;
            }
        }

        public string Street
        {
            get { return this.street; }
            set
            {
                street = value;
            }
        }

        public string City
        {
            get { return this.city; }
            set
            {
                city = value;
            }
        }

        public string Country
        {
            get { return this.country; }
            set
            {
                country = value;
            }
        }

        //Method
        public override string ToString()
        {
            return number + " " + street + ", " + city + ", " + country;
        }
    }
}
