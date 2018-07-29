using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenFinch.Startup))]
namespace GreenFinch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
