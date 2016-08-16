using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuildSite.Startup))]
namespace GuildSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
