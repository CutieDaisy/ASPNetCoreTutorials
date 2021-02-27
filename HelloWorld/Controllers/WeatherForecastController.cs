using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {

        }


        [HttpGet("answer")]
        public int GetAnswer()
        {
            var answer = 6 + 8;
            return answer;
        }

        [HttpGet("age")]
        public int GetAge()
        {
            var age = 18;
            return age;
        }

        [HttpGet("name")]
        public string GetName()
        {
            var name = "yaw";
            return name;
        }
    }


}
