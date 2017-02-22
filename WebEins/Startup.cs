using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebEins.Startup))]
namespace WebEins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
