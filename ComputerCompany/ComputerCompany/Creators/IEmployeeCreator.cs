using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCompany.Products;

namespace ComputerCompany.Creators
{
    public interface IEmployeeCreator
    {
        Employee CreateEmployee(string name,string position, decimal salary, decimal bonus);
    }
}
