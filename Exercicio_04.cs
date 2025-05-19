using System;

class Exercicio_04
{
    public static void executar()
    {
        var sensor = new TemperatureSensor();
        sensor.TemperaturaExcedida += AlertaTemperaturaExcedida;

        Console.WriteLine("\n>>>>Monitoramento de temperatura");
        Console.WriteLine("\nInsira um valor de temperatura (°C) para simulação de leitura");

        while (true)
        {
            Console.Write("\nTemperatura atual: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double temperatura))
            {
                sensor.AtualizarTemperatura(temperatura);
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }

    public class TemperatureSensor
    {
        public event EventHandler<TemperatureExceeded>? TemperaturaExcedida;

        public void AtualizarTemperatura(double temperatura)
        {
            if (temperatura > 100)
            {
                OnTemperaturaExcedida(new TemperatureExceeded(temperatura));
            }
        }

        protected virtual void OnTemperaturaExcedida(TemperatureExceeded e)
        {
            TemperaturaExcedida?.Invoke(this, e);
        }
    }

    public class TemperatureExceeded : EventArgs
    {
        public double Temperatura { get; }
        public TemperatureExceeded(double temperatura)
        {
            Temperatura = temperatura;
        }
    }

    private static void AlertaTemperaturaExcedida(object? sender, TemperatureExceeded e)
    {
        Console.WriteLine("\n!!!!ALERTA!!!!");
        Console.WriteLine($"\nAlerta: Temperatura além dos limites seguros de operação! Temperatura atual: {e.Temperatura}°C");
    }
}
