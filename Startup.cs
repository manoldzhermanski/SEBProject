using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEBProject.Startup))]
namespace SEBProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
