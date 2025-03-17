using System;
using System.IO;

class Program
{
    static void Main()
    {
       
        Console.Write("Введіть шлях до вихідного файлу: ");
        string inputFilePath = Console.ReadLine();

        Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
        string outputFilePath = Console.ReadLine();

        try
        {
            
            string content = File.ReadAllText(inputFilePath);

            
            File.WriteAllText(outputFilePath, content);

            
            Console.WriteLine("Файл успішно скопійовано!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Помилка: вихідний файл не знайдено.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Помилка при роботі з файлами: {ex.Message}");
        }
    }
}
