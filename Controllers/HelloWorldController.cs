using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MonterrosaDC2AllForOneAPI.Services;

namespace MonterrosaDC2AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldServices _helloWorldServices;
        public HelloWorldController(HelloWorldServices helloWorldServices)
        {
            _helloWorldServices = helloWorldServices;
        }

        [HttpGet]
        [Route("Hello/{userName}")]
        public string Hello(string userName)
        {
            return _helloWorldServices.GreetPerson(userName);
        }
    }
}