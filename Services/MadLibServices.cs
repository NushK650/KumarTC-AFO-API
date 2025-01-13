using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class MadLibServices
    {
      public string MadLib(string name, string place, string adjective, string activity)
        {
            return $"there once was a man named {name} who loved going to {place}. they were a very {adjective} person. they also loved {activity}. the end.";
        }  
    }
}