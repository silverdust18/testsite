using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaidSafe.Startup))]
namespace MaidSafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
