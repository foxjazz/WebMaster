using System.Security.Cryptography;
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
        public IConfiguration conf;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IDogger dg, IConfiguration c)
        {
            // _logger = logger;
            refcounter++;
            var tm = new Testme(dg, c);
            tm.doone("test me now");
            conf = c;
        }
        
        [HttpGet(Name = "GetWeatherForecast")]

        public string GetSpecial()
        {
            var sec = conf.GetSection("MySpecial");
            
               var s = sec["special2"];
            return s;
        }
            
            
        /*[HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }*/
    }
}