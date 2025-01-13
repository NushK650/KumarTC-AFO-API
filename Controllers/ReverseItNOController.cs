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
    public class ReverseItNOController : ControllerBase
    {
        private readonly ReverseItNOServices _reverseItNOServices;

        public ReverseItNOController(ReverseItNOServices reverseItNOServices)
        {
            _reverseItNOServices = reverseItNOServices;
        }




        [HttpGet]
        [Route("ReverseItNO/{input}")]
        public string ReverseItNO(string input)
        {
            return _reverseItNOServices.ReverseItNO(input);
        }
    }
}