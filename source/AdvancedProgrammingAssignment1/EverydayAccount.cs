using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgrammingAssignment1
{
    internal class EverydayAccount : Account
    {
        public EverydayAccount(int Balance, Customer customer) : base(Balance, customer)
        {
             type = "Everyday";
        }
    }
}
