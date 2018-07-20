using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEPApplication0.Startup))]
namespace SEPApplication0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
