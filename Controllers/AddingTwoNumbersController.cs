using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonterrosaDC2AllForOneAPI.Services;

namespace MonterrosaDC2AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;
        public AddingTwoNumbersController(AddingTwoNumbersServices addingTwoNumbersServices)
        {
            _addingTwoNumbersServices = addingTwoNumbersServices;
        }

        [HttpGet]
        [Route("AddNumbers/{firstNumber}/{secondNumber}")]
        public string AddNumbers(string firstNumber, string secondNumber)
        {
            return _addingTwoNumbersServices.AddNumbers(firstNumber, secondNumber);
        }
    }
}