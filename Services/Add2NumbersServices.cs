using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class Add2NumbersServices
    {
        public string Add(int num1, int num2)
        {
            return $"{num1} + {num2} = {num1 + num2}.";
        }
    }
}