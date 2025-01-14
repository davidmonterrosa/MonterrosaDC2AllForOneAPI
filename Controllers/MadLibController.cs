using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonterrosaDC2AllForOneAPI.Models;
using MonterrosaDC2AllForOneAPI.Services;

namespace MonterrosaDC2AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpPost]
        [Route("GenerateStory")]
        public string GenerateStory(MadLibInput madLibInput)
        {
            return _madLibServices.MadLib(madLibInput);
        }

    }
}