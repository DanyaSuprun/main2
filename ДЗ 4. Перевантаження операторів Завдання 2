using System;

class City
{
    private string name;
    private int population;

   
    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Population
    {
        get => population;
        set
        {
            if (value >= 0)
                population = value;
            else
                Console.WriteLine("Кількість жителів не може бути від’ємною.");
        }
    }

    
    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }

    
    public static City operator +(City c, int amount)
    {
        return new City(c.Name, c.Population + amount);
    }

    
    public static City operator -(City c, int amount)
    {
        int newPopulation = c.Population - amount;
        if (newPopulation < 0) newPopulation = 0;
        return new City(c.Name, newPopulation);
    }

   
    public static bool operator ==(City c1, City c2)
    {
        return c1.Population == c2.Population;
    }

    
    public static bool operator !=(City c1, City c2)
    {
        return c1.Population != c2.Population;
    }

    
    public static bool operator >(City c1, City c2)
    {
        return c1.Population > c2.Population;
    }

   
    public static bool operator <(City c1, City c2)
    {
        return c1.Population < c2.Population;
    }

    
    public override string ToString()
    {
        return $"Місто: {Name}, Населення: {Population}";
    }

    
    public override bool Equals(object obj)
    {
        if (obj is City other)
            return this.Population == other.Population;
        return false;
    }

    public override int GetHashCode()
    {
        return Population.GetHashCode();
    }
}
class Program
{
    static void Main()
    {
        City city1 = new City("Київ", 2800000);
        City city2 = new City("Львів", 720000);

        Console.WriteLine(city1);
        Console.WriteLine(city2);

        city2 = city2 + 50000;
        Console.WriteLine("\nПісля збільшення населення Львова:");
        Console.WriteLine(city2);

        city1 = city1 - 100000;
        Console.WriteLine("\nПісля зменшення населення Києва:");
        Console.WriteLine(city1);

        Console.WriteLine($"\nЧи однакова кількість жителів? {city1 == city2}");
        Console.WriteLine($"Чи Київ більше Львова? {city1 > city2}");

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}
