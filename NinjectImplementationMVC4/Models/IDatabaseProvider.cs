using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectImplementationMVC4.Models
{
    public interface IDatabaseProvider
    {
        string GetGreetingMessage();
    }
}
