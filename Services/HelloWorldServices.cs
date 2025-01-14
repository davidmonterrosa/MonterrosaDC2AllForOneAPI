using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDC2AllForOneAPI.Services
{
    public class HelloWorldServices
    {
        public string GreetPerson(string userName) 
        {
            return $"Greetings, {userName}! Welcome to Level 2.";
        }
    }
}