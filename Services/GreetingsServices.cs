using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class GreetingsServices
    {
        public List<string> greet = new();
         public string greetings(string name, string time )
        {
            return $" your name is {name} and you woke up at {time}.";
        }
    }
}