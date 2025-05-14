class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha a opção do exercício que deseja visualizar a resolução");
            Console.WriteLine("1 - Delegate personalizado para descontos");
            Console.WriteLine("13 - Sair");
            Console.Write("\nDigite a opção desejada: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Exercicio_01.executar();
                    break;
                case "13":
                    Console.WriteLine("\n\nSaindo...");
                    return;
                default:
                    Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                    break;
            }
        }
    }
}