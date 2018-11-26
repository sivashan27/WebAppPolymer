using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPolymer.Startup))]
namespace WebAppPolymer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
