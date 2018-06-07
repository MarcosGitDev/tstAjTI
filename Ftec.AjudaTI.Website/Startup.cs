using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ftec.AjudaTI.Website.Startup))]
namespace Ftec.AjudaTI.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
