using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDC2AllForOneAPI.Services
{
    public class AskingQuestionsServices
    {
        public string AskQuestions(string userName, string time)
        {
            return $"Your name is {userName} and you woke up at {time}.";
        }
    }
}