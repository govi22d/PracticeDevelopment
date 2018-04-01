using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectImplementationMVC4.Models
{
    public class DatabaseEntityFramework : IDatabaseProvider
    {
        public string GetGreetingMessage()
        {
            return "Hello from DatabaseEntityFramework";
        }
    }
}