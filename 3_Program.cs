
using System;
int num1, num2, result;
string operation;

Console.WriteLine("Введіть перше число:");
num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введіть дію ділення ");
operation = Console.ReadLine();

Console.WriteLine("Введіть друге число:");
num2 = Convert.ToInt16(Console.ReadLine());

try
{
    Console.WriteLine(num1 / num2);
}

catch (DivideByZeroException)
{
    Console.WriteLine("Ділення на нуль");

 }
   




