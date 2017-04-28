using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Galileo.Web.Startup))]
namespace Galileo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
