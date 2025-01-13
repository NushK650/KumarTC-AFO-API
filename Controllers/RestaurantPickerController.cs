using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KumarTC_AFO_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace KumarTC_AFO_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController (RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        
        

        [HttpGet]
        [Route("RestaurantPicker/{input}")]
public string RestaurantPicker(string FastFoodCasualDiningFineDining)
        {
            return _restaurantPickerService.RestaurantPicker(FastFoodCasualDiningFineDining);
        }
    }
}