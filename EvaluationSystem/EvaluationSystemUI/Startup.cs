using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvaluationSystemUI.Startup))]
namespace EvaluationSystemUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
