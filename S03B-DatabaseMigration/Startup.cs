using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(X02c_DatabaseMigration.Startup))]
namespace X02c_DatabaseMigration
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
