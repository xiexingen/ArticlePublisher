using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace XXG.ArticlePublisher.Web
{
    [Dependency(ReplaceServices = true)]
    public class ArticlePublisherBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ArticlePublisher";
    }
}
