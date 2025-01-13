using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(int number)
        {
            if (number % 2 == 1)
            {
                return $"Your number {number} is odd";
            }
            else if (number % 2 == 0)
            {
                return $"Your number {number} is even";
            }
            else
            {
                return "invalid input";
            }


        }
    }
}