using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCompany.Products;

namespace ComputerCompany.Creators
{
    public class EngineerCreator : IEmployeeCreator
    {
        public Employee CreateEmployee(string name, string position, decimal salary, decimal bonus)
            => new Engineer(name, position, salary, bonus);
    }
}
