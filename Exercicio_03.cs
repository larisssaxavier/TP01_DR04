using System;

class Exercicio_03
{ 
    public static void executar()
    {
        Console.WriteLine("\n>>>>Calculadora de área (cm)");
        Console.WriteLine("Digite o valor da base do retângulo: ");
        double baseRetangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do retângulo: ");
        double alturaRetangulo = double.Parse(Console.ReadLine());

        Func<double, double, double> calcularArea = (baseA, alturaB) => baseA * alturaB;

        double areaRetangulo = calcularArea(baseRetangulo, alturaRetangulo);

        Console.WriteLine($"\nOs valores passados foram: Base({baseRetangulo} cm) x Altura ({alturaRetangulo} cm)" +
                          $" \n\nA área calculada do retângulo é: {areaRetangulo}cm");
    }
}
