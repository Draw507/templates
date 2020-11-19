using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(com.draw507.web.Startup))]
namespace com.draw507.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
