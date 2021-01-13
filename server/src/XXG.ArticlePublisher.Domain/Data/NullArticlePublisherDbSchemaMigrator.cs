using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace XXG.ArticlePublisher.Data
{
    /* This is used if database provider does't define
     * IArticlePublisherDbSchemaMigrator implementation.
     */
    public class NullArticlePublisherDbSchemaMigrator : IArticlePublisherDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}