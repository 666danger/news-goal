using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(News_Goal.Web.Startup))]
namespace News_Goal.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
