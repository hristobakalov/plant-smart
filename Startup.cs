using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plant_Smart.Startup))]
namespace Plant_Smart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
