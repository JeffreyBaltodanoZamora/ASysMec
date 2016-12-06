using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASysMec.Startup))]
namespace ASysMec
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
