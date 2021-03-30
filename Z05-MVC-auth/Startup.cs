using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Z05_MVC_auth.Startup))]
namespace Z05_MVC_auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
