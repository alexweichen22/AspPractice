using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseMigrationExample.Startup))]
namespace DatabaseMigrationExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
