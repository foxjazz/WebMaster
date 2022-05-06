using Microsoft.AspNetCore.Mvc;
using myLib;
using DogManager;
namespace WebMaster.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public static int refcounter;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IDogger dg)
        {
            // _logger = logger;
            refcounter++;
            var tm = new Testme(dg);
            tm.doone("test me now");
            Testme.mystatic(refcounter);
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}