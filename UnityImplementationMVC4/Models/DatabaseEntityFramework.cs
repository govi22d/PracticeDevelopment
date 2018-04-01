using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityImplementationMVC4.Models
{
    public class DatabaseEntityFramework : IDatabaseProvider
    {
        public string GetGreetingMessage()
        {
            return "Hello from DatabaseEntityFramework";
        }
    }
}