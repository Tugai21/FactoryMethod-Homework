package creators;

import products.Employee;

public interface IEmployeeCreator {
    Employee createEmployee(String name, String position, double salary, double bonus);
}