using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTaiLieu.Startup))]
namespace WebTaiLieu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
