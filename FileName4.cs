using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Створення StringBuilder для зберігання звіту
        StringBuilder report = new StringBuilder();

        // Додавання заголовка
        report.AppendLine("Звіт подій:");

        // Додавання дати
        report.AppendLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
        report.AppendLine(); // Порожній рядок для відділення дати та подій

        // Додавання списку подій
        Console.WriteLine("Введіть події. Для завершення введіть 'exit'.");

        while (true)
        {
            // Користувач вводить подію
            string eventInput = Console.ReadLine();

            // Перевірка на команду виходу
            if (eventInput.ToLower() == "exit")
            {
                break;
            }

            // Додавання події до звіту
            report.AppendLine($"- {eventInput}");
        }

        // Виведення звіту
        Console.WriteLine("\nЗгенерований звіт:");
        Console.WriteLine(report.ToString());
    }
}
