using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Desafio Xadrez ===");

        Console.Write("Informe a peça (torre, bispo, cavalo): ");
        string peca = Console.ReadLine()?.ToLower();

        Console.Write("Posição inicial (ex: a1): ");
        string de = Console.ReadLine()?.ToLower();

        Console.Write("Posição final (ex: c3): ");
        string para = Console.ReadLine()?.ToLower();

        bool valido = ValidadorDeMovimento.Validar(peca, de, para);

        Console.WriteLine(valido
            ? "✅ Movimento válido!"
            : "❌ Movimento inválido!");
    }
}
