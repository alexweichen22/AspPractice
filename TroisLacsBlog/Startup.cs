using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TroisLacsBlog.Startup))]
namespace TroisLacsBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
