using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITemperatura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversorTemperaturasController : ControllerBase
    {
        [HttpGet("Fahrenheit/{temperatura}")]
        public object Get(
            [FromServices]ILogger<ConversorTemperaturasController> logger,
            double temperatura)
        {
            logger.LogInformation(
                $"Recebida temperatura para conversão: {temperatura}");

            return new
            {
                Fahrenheit = temperatura,
                Celsius = ConversorTemperatura.FahrenheitParaCelsius(temperatura)
            };
        }
    }
}