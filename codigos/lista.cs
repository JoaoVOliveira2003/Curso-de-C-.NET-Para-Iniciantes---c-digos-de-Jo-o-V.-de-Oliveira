using System;
using System.Collections.Generic;

class Lista
{
        public static void Rodar()
    {
        // BankAccount conta1 = new BankAccount("João", 1000, logger);
        // BankAccount conta2 = new BankAccount("Maria", 500, logger);
        // List<BankAccount> contas = new List<BankAccount> { conta1, conta2 };
        // foreach (var conta in contas)
        // {
        //     Console.WriteLine($"Conta de {conta.Name} tem saldo inicial de {conta.Balance}");
        //     conta.Deposit(200);
        // }



        // Criando uma lista de strings
        List<string> nomes = new List<string>();

        // Adicionando elementos na lista
        nomes.Add("João");
        nomes.Add("Maria");
        nomes.Add("Carlos");
        nomes.Add("Ana");

        // Acessando elementos
        Console.WriteLine("Primeiro nome: " + nomes[0]);

        // Iterando sobre a lista
        Console.WriteLine("\nTodos os nomes:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        // Verificando se um nome existe na lista
        if (nomes.Contains("Carlos"))
        {
            Console.WriteLine("\nCarlos está na lista.");
        }

        // Removendo um item
        nomes.Remove("Maria");

        // Exibindo lista atualizada
        Console.WriteLine("\nLista após remoção:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}
