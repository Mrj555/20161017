using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(word1.Startup))]
namespace word1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
