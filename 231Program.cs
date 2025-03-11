using System;
using System.Collections.Generic;

public class Bank
{
    private Dictionary<string, double> accounts = new Dictionary<string, double>();

    
    public void AddAccount(string accountName, double initialBalance)
    {
        accounts[accountName] = initialBalance;
        Console.WriteLine($"Рахунок '{accountName}' додано з балансом {initialBalance}");
    }

    
    public void Deposit(string accountName, double amount)
    {
        if (accounts.ContainsKey(accountName))
        {
            accounts[accountName] += amount;
            Console.WriteLine($"Поповнено рахунок {accountName} на {amount}. Новий баланс: {accounts[accountName]}");
        }
        else
        {
            Console.WriteLine($"Рахунок '{accountName}' не знайдено.");
        }
    }

    
    public void Withdraw(string accountName, double amount)
    {
        if (accounts.ContainsKey(accountName))
        {
            if (accounts[accountName] >= amount)
            {
                accounts[accountName] -= amount;
                Console.WriteLine($"Знято {amount} з рахунку {accountName}. Новий баланс: {accounts[accountName]}");
            }
            else
            {
                Console.WriteLine($"Недостатньо коштів на рахунку {accountName}");
            }
        }
        else
        {
            Console.WriteLine($"Рахунок '{accountName}' не знайдено.");
        }
    }

   
    public void DisplayBalance(string accountName)
    {
        if (accounts.ContainsKey(accountName))
        {
            Console.WriteLine($"Баланс рахунку '{accountName}': {accounts[accountName]}");
        }
        else
        {
            Console.WriteLine($"Рахунок '{accountName}' не знайдено.");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        
        bank.AddAccount("Heikki's account", 100.00);
        bank.AddAccount("Heikki's Swiss account", 1000000.00);

        
        bank.Deposit("Heikki's account", 50.00);
        bank.Withdraw("Heikki's account", 30.00);
        bank.DisplayBalance("Heikki's account");

        bank.Deposit("Heikki's Swiss account", 500.00);
        bank.Withdraw("Heikki's Swiss account", 1000.00);
        bank.DisplayBalance("Heikki's Swiss account");

        
        bank.Withdraw("Non-existent account", 100);
        bank.DisplayBalance("Non-existent account");
    }
}
