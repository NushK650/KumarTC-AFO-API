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
    public class GreetingsController : ControllerBase
    {
        private readonly GreetingsServices _greetingsSevices;
        public GreetingsController(GreetingsServices greetingsServices)
        {
            _greetingsSevices = greetingsServices;
        }
        [HttpGet]
        [Route("greetings/{name}/{time}")]
        public string greetings(string name, string time)
        {
            return _greetingsSevices.greetings(name, time);
        }
    }
}