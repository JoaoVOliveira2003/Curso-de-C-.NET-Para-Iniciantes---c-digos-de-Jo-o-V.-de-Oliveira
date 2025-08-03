
namespace cursoCsharp.Codigos
{
    public class classeBasica
    {
        public static void Rodar()
        {
            //Fazendo isso
            Teste t = new Teste();

            t.x = 10;
            Console.WriteLine(t.x);
        }

        class Teste
        {
            public int x;
        }
    }
}