
using System;

public class Play
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Назва: {Title}, Автор: {Author}, Жанр: {Genre}, Рік: {Year}");
    }

    ~Play()
    {
        Console.WriteLine($"П'єса \"{Title}\" була знищена (деструктор).");
    }
}


public class PlayTest
{
    public static void RunTest()
    {
        Play play = new Play("Гамлет", "Вільям Шекспір", "Трагедія", 1601);
        play.DisplayInfo();
        play = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}


public enum StoreType
{
    Продовольчий,
    Господарський,
    Одяг,
    Взуття
}

public class Store : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public StoreType Type { get; set; }

    public Store(string name, string address, StoreType type)
    {
        Name = name;
        Address = address;
        Type = type;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Назва: {Name}, Адреса: {Address}, Тип: {Type}");
    }

    public void Dispose()
    {
        Console.WriteLine($"Магазин \"{Name}\" виведено з експлуатації (Dispose).");
    }
}


public class StoreTest
{
    public static void RunTest()
    {
        using (Store store = new Store("АТБ", "вул. Шевченка, 12", StoreType.Продовольчий))
        {
            store.DisplayInfo();
        }
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Тестування класу П'єса:");
        PlayTest.RunTest();

        Console.WriteLine("\nТестування класу Магазин:");
        StoreTest.RunTest();
    }
}
