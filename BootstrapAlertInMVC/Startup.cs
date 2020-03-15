using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapAlertInMVC.Startup))]
namespace BootstrapAlertInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
