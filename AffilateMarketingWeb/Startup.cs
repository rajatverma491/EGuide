using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AffilateMarketingWeb.Startup))]
namespace AffilateMarketingWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
