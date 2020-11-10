using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidationEg.Startup))]
namespace ValidationEg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
