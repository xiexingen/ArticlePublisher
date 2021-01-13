using XXG.ArticlePublisher.MongoDB;
using Xunit;

namespace XXG.ArticlePublisher
{
    [CollectionDefinition(ArticlePublisherTestConsts.CollectionDefinitionName)]
    public class ArticlePublisherDomainCollection : ArticlePublisherMongoDbCollectionFixtureBase
    {

    }
}
