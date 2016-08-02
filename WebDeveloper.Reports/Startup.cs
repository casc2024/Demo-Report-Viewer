using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDeveloper.Reports.Startup))]
namespace WebDeveloper.Reports
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
