using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3HM.Startup))]
namespace _3HM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
