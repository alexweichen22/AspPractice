using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XBlog.Startup))]
namespace XBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
