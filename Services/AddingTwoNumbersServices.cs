using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDC2AllForOneAPI.Services
{
    public class AddingTwoNumbersServices
    {
        public string AddNumbers(string firstNumberString, string secondNumberString)
        {
            int num1;
            int num2;
            int sum;
            bool validFirstNumber = int.TryParse(firstNumberString, out num1);
            bool validSecondNumber = int.TryParse(secondNumberString, out num2);

            if(validFirstNumber == false || validSecondNumber == false)
            {
                return "Invalid Input: Make sure you are typing two integer numbers.";
            }
            else
            {
                sum = num1 + num2;
            }



        // Addition of the two converted integer values originally entered as strings by the user.

            return $"The sum of {firstNumberString} and {secondNumberString} is {sum}.";
        }
    }
}