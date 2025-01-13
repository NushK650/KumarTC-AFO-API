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
    public class Add2NumbersController : ControllerBase
    {
        private readonly Add2NumbersServices _add2NumbersSevices;

        public Add2NumbersController (Add2NumbersServices add2NumbersServices)
        {
            _add2NumbersSevices = add2NumbersServices;
        }

        [HttpGet]
        [Route("Add2Numbers/{num1}")]
        
       public string Add(int num1, int num2)
        {
            return _add2NumbersSevices.Add(num1, num2);
        }
    }
}