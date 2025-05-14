using System;

public delegate decimal CalculateDiscount(decimal precoOriginal);

class Exercicio_01
{
    public static void executar()
    {
        Console.Write("\nInforme o preço do produto: R$");
        string? input = Console.ReadLine();
        if (!decimal.TryParse(input, out decimal precoOriginal))
        {
            Console.WriteLine("Valor inválido!");
            return;
        }

        CalculateDiscount calcularDesconto = aplicaDesconto;

        decimal precoComDesconto = calcularDesconto(precoOriginal);

        Console.WriteLine($"\nPreço original: {precoOriginal:C}");
        Console.WriteLine($"Preço com desconto(10%): {precoComDesconto:C}");
    }

    public static decimal aplicaDesconto(decimal precoOriginal)
    {
        decimal desconto = 0.1m;
        return precoOriginal - (precoOriginal * desconto);
    }
}
