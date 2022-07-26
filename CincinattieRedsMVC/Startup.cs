using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CincinattieRedsMVC.Startup))]
namespace CincinattieRedsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
