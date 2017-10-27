using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lund.Timestamp.AspNet.MVC.Startup))]
namespace Lund.Timestamp.AspNet.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
