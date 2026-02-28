package creators;

import products.*;

public class ManagerCreator implements IEmployeeCreator {
    @Override
    public Employee createEmployee(String name, String position, double salary, double bonus) {
        return new Manager(name, position, salary, bonus);
    }
}