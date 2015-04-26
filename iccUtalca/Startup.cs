using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iccUtalca.Startup))]
namespace iccUtalca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
