package creators;

import products.*;

public class EngineerCreator implements IEmployeeCreator {
    @Override
    public Employee createEmployee(String name, String position, double salary, double bonus) {
        return new Engineer(name, position, salary, bonus);
    }
}