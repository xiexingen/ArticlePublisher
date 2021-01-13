using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace XXG.ArticlePublisher
{
    public class ArticlePublisherWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<ArticlePublisherWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}