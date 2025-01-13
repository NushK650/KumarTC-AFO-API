using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class ReverseItNOServices
    {
        public string ReverseItNO( string input)
        {
            int number;
            bool var = int.TryParse(input, out number);
            if(var)
            {
                int reverse = 0;
                while(number > 0)
                {
                    reverse = reverse * 10 + number % 10;
                    number = number/10;
                }
                return $"{input} reversed is {reverse}";
            }
            else
            {
                return "invalid input";
            }
        }
    }
}