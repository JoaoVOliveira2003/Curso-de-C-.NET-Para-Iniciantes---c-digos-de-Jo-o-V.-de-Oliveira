using System;
using System.Collections.Generic;

// Classe genérica que armazena e manipula uma lista de qualquer tipo
public class tipoGenerico<T>
{
    private List<T> itens = new List<T>();

    public void Adicionar(T item)
    {
        itens.Add(item);
    }

    public void Remover(T item)
    {
        itens.Remove(item);
    }

    public void ExibirTodos()
    {
        foreach (T item in itens)
        {
            Console.WriteLine(item);
        }
    }

    public int Contar()
    {
        return itens.Count;
    }
}
