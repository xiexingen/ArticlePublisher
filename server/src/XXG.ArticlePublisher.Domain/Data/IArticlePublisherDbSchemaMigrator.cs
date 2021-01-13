using System.Threading.Tasks;

namespace XXG.ArticlePublisher.Data
{
    public interface IArticlePublisherDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
