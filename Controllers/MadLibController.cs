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
    public class MadLibController : ControllerBase
    {
      private readonly MadLibServices _madLibSevices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibSevices = madLibServices;
        }

        
        

        [HttpGet]
        [Route("MadLib/{name}/{place}/{adjective}/{activity}")]
        public string MadLib(string name, string place, string adjective, string activity)
        {
            return _madLibSevices.MadLib(name, place, adjective, activity);
        }  
    }
}