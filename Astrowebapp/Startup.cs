using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Astrowebapp.Startup))]
namespace Astrowebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
