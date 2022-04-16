using Microsoft.AspNetCore.Mvc;

namespace SuperHero.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("weather")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 6).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
// Bu bölümü incelerken swanger çalýþtýrýn
// Þimdi Bir Model Oluþturcaz Bu Model Katmanlý Mimaride Entity veya Model Katmanlarýnda Oluþturuluyor---SuperHeroModel----< Hemen Git
// Model Oluþturmak için SuperHero.Apý üzerinde class oluþturuyoruz.