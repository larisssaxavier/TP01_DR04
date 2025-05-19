using System;
using System.IO;

class Exercicio_06
{
    public static void executar()
    {
        var logger = new Logger();
        
        Action<string> logHandler = logger.LogToConsole;
        logHandler += logger.LogToFile;
        logHandler += logger.LogToDatabase;

        Console.WriteLine("\n>>>>Registro de multicast com delegate");
        Console.Write("\nDigite a mensagem que deseja registrar: ");
        string mensagem = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(mensagem))
        {
            logHandler(mensagem); 
        }
    }
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"\n[CONSOLE] {DateTime.Now:HH:mm:ss} - {message}");
        }
        public void LogToFile(string message)
        {
            Console.WriteLine($"\n[FILE] Mensagem gravada em log.txt");
        }
        public void LogToDatabase(string message)
        {
            Console.WriteLine($"\n[DATABASE] Registro inserido na tabela de logs: {message}");
        }
    }
}
