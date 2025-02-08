
using System;

class Program
{
    static void Main()
    {
        // Введення максимального числа для генерації простих чисел
        Console.Write("Введіть максимальне число: ");
        int maxNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"Прості числа від 1 до {maxNumber}:");

        // Перевірка кожного числа від 2 до maxNumber
        for (int num = 2; num <= maxNumber; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }

    // Метод для перевірки, чи є число простим
    static bool IsPrime(int number)
    {
        // Якщо число менше або рівне 1, воно не є простим
        if (number <= 1) return false;

        // Перевірка дільників до квадратного кореня з числа
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; // Якщо число ділиться на i, воно не просте
            }
        }

        return true; // Якщо не знайшли дільників, число просте
    }
}
