using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XHomeInventory.Startup))]
namespace XHomeInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
