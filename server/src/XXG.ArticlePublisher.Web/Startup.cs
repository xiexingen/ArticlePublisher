using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace XXG.ArticlePublisher.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<ArticlePublisherWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
