using Microsoft.AspNetCore.Mvc;

namespace PMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        

        List<int> intNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<int> Get()
        {
            // Query syntax- LINQ
            IEnumerable<int> queryResult =
                                            from num in intNumbers
                                            where num > 5 && num < 10
                                            select num;

            // Method Syntax - LINQ
            IEnumerable<int> queryResultMethod = intNumbers.Where(num => num > 5 && num < 10);
            // Excersize : Try for SQL database

            return queryResult;
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

        public string Method1()
        {

            var res_ANny= Summaries.Any(s => s.Length > 10);

            var res_All = Summaries.All(s => s.Length > 10);

            return "Hello, World!";
        }

       

    }
}
