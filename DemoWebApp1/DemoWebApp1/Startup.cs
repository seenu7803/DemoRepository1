using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebApp1.Startup))]
namespace DemoWebApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
