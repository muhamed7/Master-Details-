using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterDestails.Startup))]
namespace MasterDestails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
