
namespace cursoCsharp.Codigos
{
    public class loopEstring
    {
        public static void Rodar()
        {
            string[] names = { "Alice", "Bob", "Charlie" };

            foreach (string name in names)
            {
                Console.WriteLine($"Nome, {name}!");
            }
            //ou
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Nome, {names[i]}!");
            }
        }
    }
}