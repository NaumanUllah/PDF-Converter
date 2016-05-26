using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocumentConverter.Startup))]
namespace DocumentConverter
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
