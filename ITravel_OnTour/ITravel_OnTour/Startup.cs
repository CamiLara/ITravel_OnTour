using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITravel_OnTour.Startup))]
namespace ITravel_OnTour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
