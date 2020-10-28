using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tindero.Startup))]
namespace Tindero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
