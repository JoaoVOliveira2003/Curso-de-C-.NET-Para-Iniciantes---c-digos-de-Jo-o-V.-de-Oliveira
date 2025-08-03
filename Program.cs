using System;
using cursoCsharp.Codigos;
//https://www.youtube.com/watch?v=oTivhgjbhIg&t=5884s   | 02:09
class Program
{
    static void Main()
    {
        bankAccontt conta1 = new bankAccontt("João", 1000);
        bankAccontt conta2 = new bankAccontt("Maria", 500);

        Console.WriteLine($"Conta 1 - Nome: {conta1.Name}, Saldo: {conta1.Balance}");
        conta1.Deposit(200);
        Console.WriteLine($"Conta 1 após depósito - Nome: {conta1.Balance}");
    }
}

public class bankAccontt
{
    private string name;
    private decimal balance;

    public bankAccontt(string name, decimal balance)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty", nameof(name));
        }

        if (balance < 0)
        {
            throw new ArgumentException("Balance cannot be negative");
        }

        this.name = name;
        this.balance = balance;
    }

    // Propriedades públicas para acesso externo
    public string Name => name;
    public decimal Balance => balance;

    // Método de depósito
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive", nameof(amount));
        }
        balance += amount;
    }
   
}
