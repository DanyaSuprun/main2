using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Неможливо ділити на нуль.");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            try
            {
                Console.Write("Введіть перше число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Оберіть операцію (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = calc.Add(num1, num2);
                        break;
                    case "-":
                        result = calc.Subtract(num1, num2);
                        break;
                    case "*":
                        result = calc.Multiply(num1, num2);
                        break;
                    case "/":
                        result = calc.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Невідома операція.");
                        return;
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введено некоректне число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }
}
