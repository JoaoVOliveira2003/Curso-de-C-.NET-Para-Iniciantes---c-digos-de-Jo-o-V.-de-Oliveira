namespace cursoCsharp.Codigos
{
    public class Scanf
    {
        public static void Rodar()
        {
Console.WriteLine("Insira nome");
string nome = Console.ReadLine();

Console.Write("Insira ano de nascimento: ");
int ano = int.Parse(Console.ReadLine());

int idade = 2025 - ano;

Console.WriteLine($"Vc tem {idade} anos");
        }
    }
}