using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S05B_MVC_Auth.Startup))]
namespace S05B_MVC_Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
