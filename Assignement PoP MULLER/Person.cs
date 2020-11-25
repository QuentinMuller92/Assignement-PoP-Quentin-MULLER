using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_PoP_MULLER
{
    public class Person
    {
        internal string firstName;
        internal string lastName;

        //Constructor
        public Person (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                lastName = value;
            }
        }

        //Method
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
