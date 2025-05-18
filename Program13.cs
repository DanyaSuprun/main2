using System;

public class Money
{
    private int wholePart;
    private int centsPart;

    public int WholePart
    {
        get => wholePart;
        set
        {
            if (value < 0) throw new ArgumentException("Сума не може бути від’ємною.");
            wholePart = value;
        }
    }

    public int CentsPart
    {
        get => centsPart;
        set
        {
            if (value < 0 || value > 99) throw new ArgumentException("Копійки мають бути від 0 до 99.");
            centsPart = value;
        }
    }

    public Money(int whole, int cents)
    {
        WholePart = whole;
        CentsPart = cents;
    }

    public void Display()
    {
        Console.WriteLine($"{wholePart} грн {centsPart:D2} коп");
    }

    public void Subtract(Money amount)
    {
        int totalThis = this.wholePart * 100 + this.centsPart;
        int totalSub = amount.wholePart * 100 + amount.centsPart;

        if (totalSub > totalThis)
        {
            Console.WriteLine("Недостатньо коштів для знижки.");
            return;
        }

        int result = totalThis - totalSub;
        this.wholePart = result / 100;
        this.centsPart = result % 100;
    }
}

public class Product
{
    public string Name { get; set; }
    private Money price;

    public Product(string name, Money price)
    {
        Name = name;
        this.price = price;
    }

    public void ReducePrice(Money discount)
    {
        price.Subtract(discount);
    }

    public void ShowProduct()
    {
        Console.Write($"Товар: {Name}, Ціна: ");
        price.Display();
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        
        Console.Write("Введіть назву товару: ");
        string name = Console.ReadLine();

        Console.Write("Введіть ціну (грн): ");
        int грн = int.Parse(Console.ReadLine());

        Console.Write("Введіть копійки: ");
        int коп = int.Parse(Console.ReadLine());

        Money price = new Money(грн, коп);
        Product product = new Product(name, price);

        product.ShowProduct();

        
        Console.Write("Введіть знижку (грн): ");
        int скидкаГрн = int.Parse(Console.ReadLine());

        Console.Write("Введіть знижку (коп): ");
        int скидкаКоп = int.Parse(Console.ReadLine());

        Money discount = new Money(скидкаГрн, скидкаКоп);

        product.ReducePrice(discount);
        product.ShowProduct();
    }
}



