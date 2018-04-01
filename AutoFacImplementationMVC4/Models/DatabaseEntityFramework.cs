using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacImplementationMVC4.Models
{
    public class DatabaseEntityFramework : IDatabaseProvider
    {
        public DatabaseEntityFramework(int i, int j)
        {

        }

        public string GetGreetingMessage()
        {
            return "Hello from DatabaseEntityFramework";
        }
    }
}