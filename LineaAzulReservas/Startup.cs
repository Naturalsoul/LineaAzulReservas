using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LineaAzulReservas.Startup))]
namespace LineaAzulReservas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
