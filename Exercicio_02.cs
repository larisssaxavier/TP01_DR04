using System;

class Exercicio_02
{
    public static void executar()
    {
        Console.WriteLine("\nOlá! Escolha seu idioma / Hello! Choose your language / Hola! Elige tu idioma\n");
        Console.WriteLine("1-Português \n2-English \n3-Español");
        int opcao = int.Parse(Console.ReadLine());

        Action<string> exibirMensagem;

        switch (opcao)
        {
            case 1:
                exibirMensagem = mensagemPortugues;
                break;
            case 2:
                exibirMensagem = mensagemIngles;
                break;
            case 3:
                exibirMensagem = mensagemEspanhol;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }
        exibirMensagem("");
    }
    static void mensagemPortugues( string _)
    {
        Console.WriteLine("\nSeja bem-vindo! Sua página será exibida em PT-BR.");
    }
    static void mensagemIngles(string _)
    {
        Console.WriteLine("\nWelcome! Your page will be displayed in EN-USA.");
    }
    static void mensagemEspanhol(string _)
    {
        Console.WriteLine("\nBienvenido! Su página se mostrará en ES-ES.");
    }
}