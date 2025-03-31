using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgrammingAssignment1
{
    internal abstract class Customer
    {
        static int idcounter = 1;
        static public List<Customer> customers = new List<Customer>();
        public int customerNumber { get; private set; }
        public string name;
        public string contactDetails;
        public virtual double staffDiscount => 1;
        public List<Account> accounts = new List<Account>();

        public Customer( string Name, string ContactDetails) 
        {
            customerNumber = idcounter++;
            name = Name;
            contactDetails = ContactDetails;
            customers.Add(this);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
