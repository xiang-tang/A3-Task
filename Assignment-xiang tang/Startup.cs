using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_xiang_tang.Startup))]
namespace Assignment_xiang_tang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
