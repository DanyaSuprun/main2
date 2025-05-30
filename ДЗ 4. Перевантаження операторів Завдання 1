using System;

namespace BusinessLogic
{
    public class Employee
    {
        private string name;
        private decimal salary;

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        
        public static Employee operator +(Employee emp, decimal amount)
        {
            emp.salary += amount;
            return emp;
        }

        
        public static Employee operator -(Employee emp, decimal amount)
        {
            emp.salary -= amount;
            return emp;
        }

       
        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.salary == e2.salary;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.salary != e2.salary;
        }

        
        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.salary > e2.salary;
        }

        public static bool operator <(Employee e1, Employee e2)
        {
            return e1.salary < e2.salary;
        }

       
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return salary == other.salary;
            return false;
        }

        public override int GetHashCode()
        {
            return salary.GetHashCode();
        }

        
        public override string ToString()
        {
            return $"Ім'я: {name}, Зарплата: {salary} грн";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Іван", 14000);
            Employee emp2 = new Employee("Марія", 14000);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            Console.WriteLine("Зарплата рівна? " + (emp1 == emp2));

            Console.WriteLine("emp1 > emp2? " + (emp1 > emp2));
            Console.WriteLine("emp1 < emp2? " + (emp1 < emp2));

            
            emp1 += 1000;
            emp2 -= 500;

            Console.WriteLine("\nПісля змін:");
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            Console.WriteLine("Зарплата рівна? " + (emp1 == emp2));

            Console.ReadKey();
        }
    }
}
