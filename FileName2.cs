﻿using System;

public class Example
{
    public static void Main()
    {
        Console.Write("Введіть ім'я: ");
        string firstName = Console.ReadLine();

        Console.Write("Введіть прізвище: ");
        string lastName = Console.ReadLine();

        Console.WriteLine();
        
        string name = ((firstName.Trim() + " "  .Trim()).Trim() + " " +
                    lastName.Trim()).Trim();
        Console.WriteLine("Результат: " + name + ".");
    }
}