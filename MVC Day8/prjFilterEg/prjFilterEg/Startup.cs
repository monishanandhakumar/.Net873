using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prjFilterEg.Startup))]
namespace prjFilterEg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
