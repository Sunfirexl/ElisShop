using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElisShop.WebUI.Startup))]
namespace ElisShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
