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
    public class  OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }

        
        

        [HttpGet]
        [Route("OddOrEven/{number}")]
        public string OddOrEven(int number)
        {
            return _oddOrEvenServices.OddOrEven(number);
        }
    }
}