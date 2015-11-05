using DynamicRouteExample;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace DynamicRouteExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
