using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZarooDashboard.Startup))]
namespace ZarooDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
