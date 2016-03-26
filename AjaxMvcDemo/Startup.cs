using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxMvcDemo.Startup))]
namespace AjaxMvcDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
