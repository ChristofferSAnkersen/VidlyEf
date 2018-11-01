using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyEf.Startup))]
namespace VidlyEf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
