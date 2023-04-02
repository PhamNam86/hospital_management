using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Benhvien.Startup))]
namespace Benhvien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
