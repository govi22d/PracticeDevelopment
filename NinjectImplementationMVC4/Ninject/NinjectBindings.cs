using Ninject.Modules;
using NinjectImplementationMVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectImplementationMVC4.Ninject
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load() {
            Bind<IDatabaseProvider>().To<DatabaseEntityFramework>();
        }
    }
}