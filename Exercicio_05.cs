using System;
using System.Threading;

class Exercicio_05
{
    public static void executar(){
        var downloadManager = new DownloadManager();
        downloadManager.DownloadCompleto += (sender, NomeArquivo) =>
        {
            Console.WriteLine($"\nDownload do arquivo {NomeArquivo} concluído com sucesso!");
        };

        Console.WriteLine("\n>>>> Notificação de download");
        downloadManager.IniciarDownload("TP01_DR04.pdf", 5);
        downloadManager.IniciarDownload("videoAula_DR04.mp4", 10);

    }
    public class DownloadManager
    {
        public event EventHandler<string> DownloadCompleto;

        public void IniciarDownload(string NomeArquivo, int TempoDownload)
        {
            Console.WriteLine($"\nIniciando download do arquivo {NomeArquivo}...");
            Console.WriteLine($"Tempo estimado: {TempoDownload} segundos");

            Thread.Sleep(TempoDownload * 1000);

            OnDowloadCompleto(NomeArquivo);
        }
        protected virtual void OnDowloadCompleto(string NomeArquivo)
        {
            DownloadCompleto?.Invoke(this, NomeArquivo);
        }
    }
}
