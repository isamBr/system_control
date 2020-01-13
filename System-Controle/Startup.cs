using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(System_Controle.Startup))]
namespace System_Controle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
