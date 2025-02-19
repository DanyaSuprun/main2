
using System;


    
    
        
        int[] array = new int[10];
        Random rand = new Random();

     
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-10, 11); 
        }

        
        Console.WriteLine("Елементи масиву з парними індексами:");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine($"Індекс {i}: {array[i]}");
        }

      
        int sum = 0;

        
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        
        Console.WriteLine($"\nСума елементів масиву: {sum}");
        if (sum >= 0)
        {
            Console.WriteLine("Сума елементів масиву є невід'ємним числом.");
        }
        else
        {
            Console.WriteLine("Сума елементів масиву є від'ємним числом.");
        }
    


