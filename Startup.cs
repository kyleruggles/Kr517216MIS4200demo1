using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kr517216MIS4200demo1.Startup))]
namespace Kr517216MIS4200demo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
