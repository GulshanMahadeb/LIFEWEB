using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeLandingPage.Startup))]
namespace LifeLandingPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
