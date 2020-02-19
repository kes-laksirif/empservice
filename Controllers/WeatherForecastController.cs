using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.Odbc;

namespace empservice.Controllers
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

        [HttpGet]
        public string Get()
        {
            //public IEnumerable<WeatherForecast> Get()
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();

            string str = "DSN=alpha102b;HOST=user-PC;DB=alpha102;UID=laksiri;PWD=laksiri;PORT=16400; ";
            string sResult = "User List";

            string queryString = "SELECT \"Emp-Code\", PW, EmpNoHash FROM pub.SelfUser";
            OdbcCommand command = new OdbcCommand(queryString);

            using (OdbcConnection connection = new OdbcConnection(str))
            {
                command.Connection = connection;
                connection.Open();
                //command.ExecuteNonQuery();
                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string sUser = dataReader.GetString(0);
                    string sPwd = dataReader.GetString(1);
                    string sHash = dataReader.GetString(2);
                    sResult = sResult + "\nUser: " + sUser + ", Password: " + sPwd + ", Hash: " + sHash;
                }

                // The connection is automatically closed at 
                // the end of the Using block.
            }
            return sResult;

        }
    }
}
