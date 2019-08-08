using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EZTest.Startup))]
namespace EZTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
