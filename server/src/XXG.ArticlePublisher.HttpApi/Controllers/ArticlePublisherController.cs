using XXG.ArticlePublisher.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XXG.ArticlePublisher.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ArticlePublisherController : AbpController
    {
        protected ArticlePublisherController()
        {
            LocalizationResource = typeof(ArticlePublisherResource);
        }
    }
}