using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XRvRentPlus.Startup))]
namespace XRvRentPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
