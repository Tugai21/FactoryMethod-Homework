package products;

public abstract class Employee {
    private static final double MIN_SALARY = 30000.0;
    private static final double MAX_SALARY = 200000.0;
    private static final double MIN_BONUS = 5000.0;
    private static final double MAX_BONUS = 20000.0;
    private static final String NAME_NULL_OR_EMPTY_MESSAGE = "Името не може да е празно.";
    private static final String SALARY_OUT_OF_RANGE_MESSAGE = "Заплата трябва да бъде между %.2f и %.2f.";
    private static final String BONUS_OUT_OF_RANGE_MESSAGE = "Бонусът трябва да бъде между %.2f и %.2f.";
    private static final String POSITION_NULL_OR_EMPTY_MESSAGE = "Позицията не може да бъде празна.";
    private String name;
    private String position;
    private double salary;
    private double bonus;

    protected Employee(String name, String position, double salary, double bonus) {
        setName(name);
        setPosition(position);
        setSalary(salary);
        setBonus(bonus);
    }

    public String getPosition() {
        return position;
    }

    public void setPosition(String position) {
        if (position == null || position.trim().isEmpty()) {
            throw new IllegalArgumentException(POSITION_NULL_OR_EMPTY_MESSAGE);
        }
        this.position = position;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if (name == null || name.trim().isEmpty()) {
            throw new IllegalArgumentException(NAME_NULL_OR_EMPTY_MESSAGE);
        }
        this.name = name;
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        if (salary < MIN_SALARY || salary > MAX_SALARY) {
            throw new IllegalArgumentException(String.format(SALARY_OUT_OF_RANGE_MESSAGE, MIN_SALARY, MAX_SALARY));
        }
        this.salary = salary;
    }

    public double getBonus() {
        return bonus;
    }

    public void setBonus(double bonus) {
        if (bonus < MIN_BONUS || bonus > MAX_BONUS) {
            throw new IllegalArgumentException(String.format(BONUS_OUT_OF_RANGE_MESSAGE, MIN_BONUS, MAX_BONUS));
        }
        this.bonus = bonus;
    }

    @Override
    public String toString() {
        return String.format("Служител: %s | Име: %s, Позиция: %s, Заплата: %.2f, Бонус: %.2f",
                getClass().getSimpleName(), name, position, salary, bonus);
    }
}