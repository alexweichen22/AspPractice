using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(X02b_DataBinding.Startup))]
namespace X02b_DataBinding
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
