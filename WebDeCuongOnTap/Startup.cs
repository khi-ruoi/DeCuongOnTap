using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDeCuongOnTap.Startup))]
namespace WebDeCuongOnTap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
