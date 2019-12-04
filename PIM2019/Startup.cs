using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PIM2019.Startup))]
namespace PIM2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
