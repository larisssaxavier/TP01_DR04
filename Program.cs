class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha a opção do exercício que deseja visualizar a resolução");
            Console.WriteLine("1 - Delegate personalizado para descontos");
            Console.WriteLine("2 - Ações Multilíngues com Action<string>");
            Console.WriteLine("3 - Cálculo de Área Utilizando Func");
            Console.WriteLine("4 - Monitoramento de Temperatura com Evento Personalizado");
            Console.WriteLine("5 - Notificação de Conclusão de Download com Eventos");
            Console.WriteLine("6 - Sistema de Registro com Multicast Delegate");
            Console.WriteLine("7 - Garantia de Robustez em Invocação de Delegates");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite a opção desejada: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Exercicio_01.executar();
                    break;
                case "2":
                    Exercicio_02.executar();
                    break;
                case "3":
                    Exercicio_03.executar();
                    break;
                case "4":
                    Exercicio_04.executar();
                    break;
                case "5":
                    Exercicio_05.executar();
                    break;
                case "6":
                    Exercicio_06.executar();
                    break;
                case "7":
                    Exercicio_07.executar();
                    break;
                case "0":
                    Console.WriteLine("\n\nSaindo...");
                    return;
                default:
                    Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                    break;
            }
        }
    }
}