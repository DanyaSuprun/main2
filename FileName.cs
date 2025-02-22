﻿using System;

class Program
{
    static void Main()
    {
     
        Console.WriteLine("Введіть ім'я та прізвище:");
        string fullName = Console.ReadLine();

      
        string[] nameParts = fullName.Split(' ');

        if (nameParts.Length == 2)
        {
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            
            if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
            {
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
            }
            else
            {
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
            }


        }

    }
}