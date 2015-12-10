using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataDemo.Startup))]
namespace DataDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
