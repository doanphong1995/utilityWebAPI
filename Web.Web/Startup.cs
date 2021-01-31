using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Web.Startup))]
namespace Web.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
