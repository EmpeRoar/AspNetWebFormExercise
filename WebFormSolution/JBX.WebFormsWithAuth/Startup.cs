using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JBX.WebFormsWithAuth.Startup))]
namespace JBX.WebFormsWithAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
