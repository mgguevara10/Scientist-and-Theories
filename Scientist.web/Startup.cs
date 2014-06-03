using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scientist.web.Startup))]
namespace Scientist.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
