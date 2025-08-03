
namespace cursoCsharp.Codigos
{
    public class TRYcATCH
    {
        public static void Rodar()
        {
            try
            {
                ifElse.Rodar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}