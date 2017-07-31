using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HR_Solution.Startup))]
namespace HR_Solution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
