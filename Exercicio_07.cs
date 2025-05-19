using System;
using System.IO;

class Exercicio_07
{
    public class SafeLogger
    {
        private Action<string> _logDelegate;

        public void AddConsoleLogger()
        {
            _logDelegate += LogToConsole;
            Console.WriteLine("\nLogger do console adicionado");
        }

        public void AddFileLogger()
        {
            _logDelegate += LogToFile;
            Console.WriteLine("\nLogger de arquivo adicionado");
        }

        public void AddDatabaseLogger()
        {
            _logDelegate += LogToDatabase;
            Console.WriteLine("\nLogger de banco de dados adicionado");
        }

        public void LogMessage(string message)
        {
            _logDelegate?.Invoke(message);
        }

        private void LogToConsole(string message)
        {
            Console.WriteLine($"[CONSOLE] {DateTime.Now:HH:mm:ss} - {message}");
        }

        private void LogToFile(string message)
        {
            try
            {
                string logEntry = $"[FILE] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}";
                Console.WriteLine("Mensagem registrada em arquivo");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gravar no arquivo: {ex.Message}");
            }
        }

        private void LogToDatabase(string message)
        {
            Console.WriteLine($"[DATABASE] Registro simulado: '{message}'");
        }
    }
    public static void executar()
    {
        var logger = new SafeLogger();

        Console.WriteLine("Sistema de Log Seguro");
        Console.WriteLine("1 - Adicionar logger do console");
        Console.WriteLine("2 - Adicionar logger de arquivo");
        Console.WriteLine("3 - Adicionar logger de banco de dados");
        Console.WriteLine("4 - Registrar mensagem");
        Console.WriteLine("0 - Sair");

        while (true)
        {
            Console.Write("\nOpção: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    logger.AddConsoleLogger();
                    break;
                case "2":
                    logger.AddFileLogger();
                    break;
                case "3":
                    logger.AddDatabaseLogger();
                    break;
                case "4":
                    Console.Write("Digite a mensagem: ");
                    string msg = Console.ReadLine();
                    logger.LogMessage(msg);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}

