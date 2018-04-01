using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityImplementationMVC4.Models
{
    public interface IDatabaseProvider
    {
        string GetGreetingMessage();
    }
}
