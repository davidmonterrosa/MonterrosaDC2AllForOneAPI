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
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("PickRestaurant")]
        public string RestaurantPicker(string restaurantCategory)
        {
            return _restaurantPickerServices.RestaurantPicker(restaurantCategory);
        }
    }
}