using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seating.Startup))]
namespace Seating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
