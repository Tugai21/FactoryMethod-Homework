using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCompany.Products
{
    public class Engineer : Employee
    {
        public Engineer(string name, string position, decimal salary, decimal bonus)
            : base(name, position, salary, bonus){}
    }
}
