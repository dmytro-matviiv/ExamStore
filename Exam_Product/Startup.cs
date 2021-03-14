using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exam_Product.Startup))]
namespace Exam_Product
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
