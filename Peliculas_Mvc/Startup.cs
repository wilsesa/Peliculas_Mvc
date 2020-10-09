using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Peliculas_Mvc.Startup))]
namespace Peliculas_Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
