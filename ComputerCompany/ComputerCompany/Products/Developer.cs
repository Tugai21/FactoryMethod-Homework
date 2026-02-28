using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCompany.Products
{
    public class Developer : Employee
    {
        public Developer(string name, string position, decimal salary, decimal bonus)
            : base(name, position, salary, bonus) { }
    }
}
