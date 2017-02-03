using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DecimalSumUsingMVC.Startup))]
namespace DecimalSumUsingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
