

double num1, num2, result;
string operation;

Console.WriteLine("Введіть перше число:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть оператора ");
operation = Console.ReadLine();

Console.WriteLine("Введіть друге число:");
num2 = Convert.ToDouble(Console.ReadLine());

switch (operation)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Результат: {num1} + {num2} = {result}");
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine($"Результат: {num1} - {num2} = {result}");
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Результат: {num1} * {num2} = {result}");
        break;
    case "/":
        result = num1 / num2;
        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
        break;

}
