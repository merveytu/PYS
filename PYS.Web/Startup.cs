using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PYS.Web.Startup))]
namespace PYS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
