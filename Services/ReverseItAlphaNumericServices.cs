using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDC2AllForOneAPI.Services
{
    public class ReverseItAlphaNumericServices
    {
        public string ReverseItAlphaNumeric(string inputString)
        {
            string result = "";
            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];
            }
            return result;
        }
    }
}