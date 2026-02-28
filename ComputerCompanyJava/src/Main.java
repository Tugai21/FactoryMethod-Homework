import creators.*;
import products.Employee;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Employee> employees = new ArrayList<>();

        IEmployeeCreator[] creators = {
                new ManagerCreator(),
                new EngineerCreator(),
                new DeveloperCreator()
        };

        try {
            for (IEmployeeCreator creator : creators) {
                String typeName = creator.getClass().getSimpleName().replace("Creator", "");
                System.out.println("--- Данни за " + typeName + " ---");

                System.out.print("Име: ");
                String name = scanner.nextLine();

                System.out.print("Позиция (Junior/Senior): ");
                String position = scanner.nextLine();

                System.out.print("Заплата: ");
                String salaryInput = scanner.nextLine();
                double salary = Double.parseDouble(salaryInput);

                System.out.print("Бонус: ");
                String bonusInput = scanner.nextLine();
                double bonus = Double.parseDouble(bonusInput);

                Employee emp = creator.createEmployee(name, position, salary, bonus);
                employees.add(emp);
            }

            System.out.println("\nСписък на служителите:");
            for (Employee e : employees) {
                System.out.println(e.toString());
            }

        } catch (NumberFormatException e) {
            System.out.println("Грешка! Въведената стойност не е валидно число.");
        } catch (IllegalArgumentException e) {
            System.out.println(e.getMessage());
        } catch (Exception e) {
            System.out.println("Възникна неочаквана грешка: " + e.getMessage());
        } finally {
            scanner.close();
        }
    }
}