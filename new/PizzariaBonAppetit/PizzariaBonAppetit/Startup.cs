using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzariaBonAppetit.Startup))]
namespace PizzariaBonAppetit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
