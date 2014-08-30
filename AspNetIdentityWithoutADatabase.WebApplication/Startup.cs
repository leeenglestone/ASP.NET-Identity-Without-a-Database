using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetIdentityWithoutADatabase.WebApplication.Startup))]
namespace AspNetIdentityWithoutADatabase.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
