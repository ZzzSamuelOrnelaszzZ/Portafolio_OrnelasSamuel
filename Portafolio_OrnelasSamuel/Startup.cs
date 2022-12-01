using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portafolio_OrnelasSamuel.Startup))]
namespace Portafolio_OrnelasSamuel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
