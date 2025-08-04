using System;
using System.IO;  // Necessário para File.AppendAllText

// https://www.youtube.com/watch?v=oTivhgjbhIg&t=5889s | 02:18

class Program
{
    static void Main()
    {
        ILogger logger = new FileLogger();

        BankAccount conta1 = new BankAccount("João", 1000, logger);
        BankAccount conta2 = new BankAccount("Maria", 500, logger);

        Console.WriteLine($"Conta 1 - Nome: {conta1.Name}, Saldo: {conta1.Balance}");

        conta1.Deposit(200);

        Console.WriteLine($"Conta 1 após depósito - Saldo: {conta1.Balance}");
    }
}

public interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        // Adiciona uma quebra de linha para separar as mensagens no arquivo
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}

public class BankAccount
{
    private string name;
    private decimal balance;
    private ILogger logger;

    public BankAccount(string name, decimal balance, ILogger logger)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name cannot be null or empty", nameof(name));

        if (balance < 0)
            throw new ArgumentException("Balance cannot be negative");

        this.name = name;
        this.balance = balance;
        this.logger = logger;
    }

    public string Name => name;
    public decimal Balance => balance;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive", nameof(amount));

        balance += amount;
        logger.Log($"Depósito de {amount} efetuado. Saldo atual: {balance}");
    }
}
