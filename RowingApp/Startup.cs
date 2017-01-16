using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RowingApp.Startup))]
namespace RowingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
