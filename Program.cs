using cursoCsharp.Codigos;

class Program
{
    static void Main()
    {
        //Fazendo isso
        Teste t = new Teste();

        t.x = 10;
        Console.WriteLine(t.x);


    }
}

class Teste
{
    public int x;
}