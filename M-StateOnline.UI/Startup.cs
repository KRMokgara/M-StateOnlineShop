using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M_StateOnline.UI.Startup))]
namespace M_StateOnline.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
