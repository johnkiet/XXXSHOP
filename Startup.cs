using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewShop.Startup))]
namespace NewShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
