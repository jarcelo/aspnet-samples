using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pet_rescue.Startup))]
namespace pet_rescue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
