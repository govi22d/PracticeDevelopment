using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDA.Startup))]
namespace PDA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
