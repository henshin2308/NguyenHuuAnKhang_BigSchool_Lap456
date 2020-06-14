using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnKhang_Bigschool.Startup))]
namespace AnKhang_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
