using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mantenimiento_usuario.Startup))]
namespace Mantenimiento_usuario
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
