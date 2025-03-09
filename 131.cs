using System;
using System.Collections.Generic;

class Program
{
    // Клас для представлення кожної справи
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItem(string title)
        {
            Title = title;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{(IsCompleted ? "[X]" : "[ ]")} {Title}";
        }
    }

    // Список справ
    static List<TodoItem> todoList = new List<TodoItem>();

    // Функція для додавання нової справи
    static void AddTodo()
    {
        Console.Write("Введіть назву нової справи: ");
        string title = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Назва справи не може бути порожньою.");
            return;
        }

        todoList.Add(new TodoItem(title));
        Console.WriteLine("Справу додано.");
    }

    // Функція для виведення всіх справ
    static void DisplayTodos()
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("Список справ порожній.");
            return;
        }

        Console.WriteLine("Список справ:");
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}");
        }
    }

    // Функція для позначення справи як виконаної
    static void MarkAsCompleted()
    {
        DisplayTodos();

        if (todoList.Count == 0)
        {
            return;
        }

        Console.Write("Введіть номер справи, яку ви хочете відмітити як виконану: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList[index - 1].IsCompleted = true;
            Console.WriteLine("Справу позначено як виконану.");
        }
        else
        {
            Console.WriteLine("Невірний номер справи.");
        }
    }

    // Функція для видалення справи
    static void DeleteTodo()
    {
        DisplayTodos();

        if (todoList.Count == 0)
        {
            return;
        }

        Console.Write("Введіть номер справи, яку ви хочете видалити: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList.RemoveAt(index - 1);
            Console.WriteLine("Справу видалено.");
        }
        else
        {
            Console.WriteLine("Невірний номер справи.");
        }
    }

    // Головне меню
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Показати всі справи");
            Console.WriteLine("3. Відмітити справу як виконану");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("5. Вийти");
            Console.Write("Виберіть дію (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTodo();
                    break;
                case "2":
                    DisplayTodos();
                    break;
                case "3":
                    MarkAsCompleted();
                    break;
                case "4":
                    DeleteTodo();
                    break;
                case "5":
                    Console.WriteLine("До побачення!");
                    return;
                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }

            Console.WriteLine("Натисніть будь-яку клавішу для продовження...");
            Console.ReadKey();
        }
    }
}
