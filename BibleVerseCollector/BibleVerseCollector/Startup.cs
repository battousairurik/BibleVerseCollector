using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibleVerseCollector.Startup))]
namespace BibleVerseCollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
