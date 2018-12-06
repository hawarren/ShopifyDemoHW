using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopifyDemoHW.Startup))]
namespace ShopifyDemoHW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
