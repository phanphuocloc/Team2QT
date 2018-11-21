using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(quyettien.Startup))]
namespace quyettien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
