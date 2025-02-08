
using System;


    
        // Запитуємо число у користувача
        Console.Write("Введіть число для генерації таблиці множення: ");
        int number = int.Parse(Console.ReadLine());

        // Генерація таблиці множення для введеного числа
        Console.WriteLine($"Таблиця множення для числа {number}:");

        // Цикл для множення числа на числа від 1 до 10
        for (int i = 1; i <= 15; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
    
