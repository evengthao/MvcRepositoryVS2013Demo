using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRepositoryVS2013Demo.Startup))]
namespace MvcRepositoryVS2013Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
