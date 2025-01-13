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
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloSevices;

        public SayHelloController (SayHelloServices sayHelloServices)
        {
            _sayHelloSevices = sayHelloServices;
        }

        
        

        [HttpGet]
        [Route("SayHello/{name}")]
       public string sayHello(string name)
        {
            return _sayHelloSevices.sayHello(name);
        }
    }
}