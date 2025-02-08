
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Запитуємо пароль від користувача
        Console.Write("Введіть пароль: ");
        string password = Console.ReadLine();

        // Перевірка пароля
        if (IsValidPassword(password))
        {
            Console.WriteLine("Пароль прийнятний.");
        }
        else
        {
            Console.WriteLine("Пароль недійсний. Він має містити мінімум 8 символів, хоча б одну цифру та хоча б один спеціальний символ.");
        }
    }

    // Метод для перевірки правильності пароля
    static bool IsValidPassword(string password)
    {
        // Перевіряємо, чи пароль містить мінімум 8 символів
        if (password.Length < 8)
        {
            return false;
        }

        // Перевіряємо, чи є хоча б одна цифра
        bool hasDigit = password.Any(char.IsDigit);

        // Перевіряємо, чи є хоча б один спеціальний символ
        bool hasSpecialChar = password.Any(ch => "!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?".Contains(ch));

        // Повертаємо true, якщо всі умови виконуються
        return hasDigit && hasSpecialChar;

    }

}