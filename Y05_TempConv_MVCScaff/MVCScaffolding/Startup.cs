using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCScaffolding.Startup))]
namespace MVCScaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
