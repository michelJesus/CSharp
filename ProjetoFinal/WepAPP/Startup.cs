using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WepAPP.Startup))]
namespace WepAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
