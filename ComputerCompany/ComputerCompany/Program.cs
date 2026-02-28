using ComputerCompany.Creators;
using ComputerCompany.Extensions;
using ComputerCompany.Products;
using System;
using System.Collections.Generic;

namespace ComputerCompany
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IEmployeeCreator[] employeeCreators = new IEmployeeCreator[]
                {
                    new ManagerCreator(),
                    new EngineerCreator(),
                    new DeveloperCreator()
                };

                List<Employee> employees = new List<Employee>();

                foreach (var creator in employeeCreators)
                {
                    var typeName = creator.GetType().Name.Replace("Creator", string.Empty);
                    Console.WriteLine($"--- Данни за {typeName} ---");

                    Console.Write("Въведете име: ");
                    string name = Console.ReadLine();

                    Console.Write("Въведете позиция (Junior/Senior/etc.): ");
                    string position = Console.ReadLine(); 

                    Console.Write("Въведете заплата: ");
                    decimal salary = decimal.Parse(Console.ReadLine());

                    Console.Write("Въведете бонус: ");
                    decimal bonus = decimal.Parse(Console.ReadLine());

                    Employee employee = creator.CreateEmployee(name, position, salary, bonus);
                    employees.Add(employee);
                }

                Console.WriteLine("\n--- Лист от служители ---");
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            catch (Exception exception)
            {
                if (exception is FormatException)
                {
                    Console.WriteLine("Прекъсване на програмата поради грешен формат на въведените данни!");
                }
                else
                {
                    Console.WriteLine(exception.Message); 
                }
            }
        }
    }
}