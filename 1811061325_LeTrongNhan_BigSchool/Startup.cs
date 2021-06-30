using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811061325_LeTrongNhan_BigSchool.Startup))]
namespace _1811061325_LeTrongNhan_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
