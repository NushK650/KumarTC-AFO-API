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
    public class  ReverseItANController  : ControllerBase
    {
        private readonly ReverseItANServices _reverseItANService;

        public ReverseItANController(ReverseItANServices reverseItANService)
        {
            _reverseItANService = reverseItANService;
        }

        
        

        [HttpGet]
        [Route("ReverseItAN/{input}")]
        public string ReverseItAN(string input)
        {
            return _reverseItANService.ReverseItAN(input);
        }
    }
}