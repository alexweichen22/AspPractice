using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaceRegistration.Startup))]
namespace RaceRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
