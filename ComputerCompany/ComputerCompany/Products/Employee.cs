using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCompany.Products
{
    public abstract class Employee
    {
        private const decimal MinSalary = 30000m;
        private const decimal MaxSalary = 200000m;
        private const decimal MinBonus = 5000m;
        private const decimal MaxBonus = 20000m;
        private const string NameNullOrEmptyMessage = "Името не може да е празно.";
        private const string SalaryOutOfRangeMessage = "Заплата трябва да бъде между {0} и {1}.";
        private const string BonusOutOfRangeMessage = "Бонусът трабва да бъде между {0} и {1}.";
        private const string PositionNullOrEmptyMessage = "Позицията не може да бъде празна.";
        private string name;
        private string position;
        private decimal salary;
        private decimal bonus;

        protected Employee(string name, string position, decimal salary, decimal bonus)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Bonus = bonus;
        }
        public string Position
        {
            get => position;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(PositionNullOrEmptyMessage);
                }
                position = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(NameNullOrEmptyMessage);
                }
                name = value;
            }
        }
        public decimal Salary
        {
            get => salary;
            set
            {
                if (value < MinSalary || value > MaxSalary)
                {
                    throw new ArgumentOutOfRangeException(string.Format(SalaryOutOfRangeMessage, MinSalary, MaxSalary));
                }
                salary = value;
            }
        }
        public decimal Bonus
        {
            get => bonus;
            set
            {
                if (value < MinBonus || value > MaxBonus)
                {
                    throw new ArgumentOutOfRangeException(string.Format(BonusOutOfRangeMessage, MinBonus, MaxBonus));
                }
                bonus = value;
            }
        }
        public override string ToString()
        {
            return $"Служител: {GetType().Name} | Име: {Name}, Позиция: {Position}, Заплата: {Salary}, Бонус: {Bonus}";
        }
    }
}
