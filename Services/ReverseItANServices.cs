using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class ReverseItANServices
    {
        public string ReverseItAN(string input)
        {
            string reverse = " ";
           for(int i =  input.Length - 1; i >= 0; i-- ) 
            {
                reverse += input[i];

            }  
            return reverse;
        }
    }
}