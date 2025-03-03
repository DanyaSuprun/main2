using System;
using System;

public static class FibonacciCalculator
{
   
    public static int GetFibonacciNumber(int n)
    {
        
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;

        
        return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
    }
}

class Program
{
    static void Main()
    {
        
        Console.Write("Введіть номер числа Фібоначчі: ");
        int n = int.Parse(Console.ReadLine());

        
        int fibonacciNumber = FibonacciCalculator.GetFibonacciNumber(n);

        Console.WriteLine($"Число Фібоначчі для {n} = {fibonacciNumber}");
    }
}
