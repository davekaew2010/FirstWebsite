using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(List2.Startup))]
namespace List2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
