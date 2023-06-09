﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ci_cd_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TestController> _logger;
        private readonly IConfiguration _configuration;

        public TestController(ILogger<TestController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();

            var test = _configuration.GetSection("MyKey").Value;
            var ASPNETCORE_ENVIRONMENT = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var DOTNET_ENVIRONMENT = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
            return @$"

            ASPNETCORE_ENVIRONMENT: {ASPNETCORE_ENVIRONMENT}
            DOTNET_ENVIRONMENT: {DOTNET_ENVIRONMENT}

            Reading config: {test} 
            ";
        }
    }
}
