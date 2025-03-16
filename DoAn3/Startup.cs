using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAn3.Startup))]
namespace DoAn3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
