package creators;

import products.*;

public class DeveloperCreator implements IEmployeeCreator {
    @Override
    public Employee createEmployee(String name, String position, double salary, double bonus) {
        return new Developer(name, position, salary, bonus);
    }
}