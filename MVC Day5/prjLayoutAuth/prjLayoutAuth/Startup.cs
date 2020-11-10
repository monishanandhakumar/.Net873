using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prjLayoutAuth.Startup))]
namespace prjLayoutAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
