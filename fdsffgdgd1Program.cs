using System;
using System.Collections.Generic;


public abstract class Product
{
    public double BasePrice { get; private set; }

    
    public Product(double basePrice)
    {
        BasePrice = basePrice;
    }

    
    public abstract double Price { get; }

    
    public abstract void PrintInfo();
}


public class Carrot : Product
{
    public Carrot(double basePrice) : base(basePrice) { }

   
    public override double Price => BasePrice;

    
    public override void PrintInfo()
    {
        Console.WriteLine($"Продукт: Морква, Ціна: {BasePrice}");
    }
}


public class Potato : Product
{
    public double Count { get; private set; }

    
    public Potato(double basePrice, double count) : base(basePrice)
    {
        Count = count;
    }

    
    public override double Price => BasePrice * Count;

    
    public override void PrintInfo()
    {
        Console.WriteLine($"Продукт: Картопля, Ціна: {BasePrice}, Кількість: {Count}, Загальна ціна: {Price}");
    }
}


public class Cucumber : Product
{
    public double Count { get; private set; }

    
    public Cucumber(double basePrice, double count) : base(basePrice)
    {
        Count = count;
    }

    
    public override double Price => BasePrice * Count;

    
    public override void PrintInfo()
    {
        Console.WriteLine($"Продукт: Огірки, Ціна: {BasePrice}, Кількість: {Count}, Загальна ціна: {Price}");
    }
}


public class Tomato : Product
{
    public Tomato(double basePrice) : base(basePrice) { }

    
    public override double Price => BasePrice;

    
    public override void PrintInfo()
    {
        Console.WriteLine($"Продукт: Помідори, Ціна: {BasePrice}");
    }
}


public class VegetableShop
{
    private List<Product> products = new List<Product>();

    
    public void AddProducts(List<Product> newProducts)
    {
        products.AddRange(newProducts);
    }

    
    public void PrintProductsInfo()
    {
        double totalPrice = 0;

        
        foreach (var product in products)
        {
            product.PrintInfo();
            totalPrice += product.Price;
        }

        
        Console.WriteLine($"Загальна ціна всіх продуктів: {totalPrice}");
    }
}


class Program
{
    static void Main()
    {
        
        var products = new List<Product>()
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2)
        };

        
        VegetableShop shop = new VegetableShop();

        
        shop.AddProducts(products);

        
        shop.PrintProductsInfo();
    }
}
