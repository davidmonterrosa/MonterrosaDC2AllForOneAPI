using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDC2AllForOneAPI.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string numberToCheck)
        {
            int convertedNumber;
            bool isValid = int.TryParse(numberToCheck, out convertedNumber);
            
            if(isValid && ((convertedNumber % 2) == 0))
            {
                return $"{numberToCheck} is even."; 
            } 
            else if(isValid)
            {
                return $"{numberToCheck} is odd.";
            } 
            else
            {
                return "Error: Invalid input. Please type an integer number.";
            }
        }
    }
}