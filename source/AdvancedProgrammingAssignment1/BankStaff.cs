using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgrammingAssignment1
{
    internal class BankStaff : Customer
    {
        public override double staffDiscount => 0.5;
        public BankStaff( string Name, string ContactDetails) : base( Name, ContactDetails) 
        {
        }
    }
}
