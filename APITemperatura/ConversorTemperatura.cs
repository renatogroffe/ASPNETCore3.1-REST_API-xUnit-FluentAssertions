using System;

namespace APITemperatura
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(double temperatura)
        {
            if (temperatura < -459.67)
            {
                throw new Exception(
                    $"Valor de temperatura em Fahrenheit inválido: {temperatura}");
            }
                
            return (temperatura - 32) / 1.8; // Simulação proposital de falha
            //return Math.Round((temperatura - 32) / 1.8, 2);
        }
    }
}