using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demotwo.Startup))]
namespace demotwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
