using Xunit;
using FluentAssertions;

namespace APITemperatura.Testes
{
    public class TestesConversorTemperatura
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(212, 100)]
        [InlineData(0, -17.78)]
        public void TestarConversaoTemperatura(
            double fahrenheit, double celsius)
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            valorCalculado.Should().Be(celsius,
                "| Falha na conversão de temperaturas: " +
                $"Vl. Fahrenheit = {fahrenheit} | " +
                $"Vl. Esperado Celsius = {celsius} | " +
                $"Vl. Calculado Celsius = {valorCalculado} |");
            //Assert.Equal(celsius, valorCalculado);
        }
    }
}