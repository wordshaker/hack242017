using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheSeeker.Startup))]
namespace TheSeeker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
