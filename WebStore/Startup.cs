using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStore.Startup))]
namespace WebStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);

            // Comment by Mihai 06.oct.2016
        }
    }
}
