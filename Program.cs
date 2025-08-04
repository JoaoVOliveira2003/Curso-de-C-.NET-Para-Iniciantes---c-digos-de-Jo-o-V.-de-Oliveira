using System;
using System.IO;  // Necessário para File.AppendAllText

// https://www.youtube.com/watch?v=oTivhgjbhIg&t=5889s | 02:30

class Program
{
    static void Main()
    {
        ILogger logger = new FileLogger("mulog.txt");

        BankAccount conta1 = new BankAccount("João", 1000, logger);
        BankAccount conta2 = new BankAccount("Maria", 500, logger);

        List<BankAccount> contas = new List<BankAccount> { conta1, conta2 };

        foreach (var conta in contas)
        {
            Console.WriteLine($"Conta de {conta.Name} tem saldo inicial de {conta.Balance}");
            conta.Deposit(200);
        }

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
    private string filePath;
    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
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
