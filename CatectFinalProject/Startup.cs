using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatectFinalProject.Startup))]
namespace CatectFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
