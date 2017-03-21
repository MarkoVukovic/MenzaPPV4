using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenzaPP.Startup))]
namespace MenzaPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
