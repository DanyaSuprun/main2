using System;

class Program
{
    
    enum DayOfWeek
    {
        Monday,    // 0
        Tuesday,   // 1
        Wednesday, // 2
        Thursday,  // 3
        Friday,    // 4
        Saturday,  // 5
        Sunday     // 6
    }

    static void Main()
    {
      
        Console.WriteLine("Введіть кількість днів:");
        int days = int.Parse(Console.ReadLine());

        
        DayOfWeek startDay = DayOfWeek.Monday;
        DayOfWeek resultDay = (DayOfWeek)((days % 7 + (int)startDay) % 7);

        
        Console.WriteLine($"День тижня через {days} днів від понеділка буде: {resultDay}");
    }
}
