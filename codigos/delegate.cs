using System;
//lembrando métodos = função
namespace cursoCsharp.Codigos
{
    // 1. Define um delegate que representa métodos que recebem dois inteiros e retornam um inteiro
    public delegate int Operacao(int a, int b);

    public class Delegate
    {
        // 2. Métodos que combinam com a assinatura do delegate
        public static int Somar(int x, int y)
        {
            return x + y;
        }

        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        // 3. Método que recebe um delegate como parâmetro
        public static void Calcular(Operacao op, int a, int b)
        {
            int resultado = op(a, b);
            Console.WriteLine("Resultado: " + resultado);
        }

        // 4. Ponto de entrada do código
        public static void Rodar()
        {
            // Passa o método Somar como delegate
            Calcular(Somar, 10, 5);        // Saída: Resultado: 15

            // Passa o método Subtrair como delegate
            Calcular(Subtrair, 10, 5);     // Saída: Resultado: 5
        }
    }
}
