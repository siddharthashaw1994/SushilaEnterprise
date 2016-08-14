using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SushilaEnterprise.Startup))]
namespace SushilaEnterprise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
