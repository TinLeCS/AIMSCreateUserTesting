using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIMSCreateUserTesting.Startup))]
namespace AIMSCreateUserTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
