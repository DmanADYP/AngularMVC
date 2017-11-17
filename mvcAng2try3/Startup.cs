using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcAng2try3.Startup))]
namespace mvcAng2try3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
