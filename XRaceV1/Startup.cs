using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XRaceV1.Startup))]
namespace XRaceV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
