using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prog6_GrandFinale.Startup))]
namespace Prog6_GrandFinale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
