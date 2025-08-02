
namespace cursoCsharp.Codigos
{
    public class ifElse
    {
        public static void Rodar()
        {
            Console.Write("Insira ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());

            int idade = 2025 - ano;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }
    }
}