using XXG.ArticlePublisher.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace XXG.ArticlePublisher.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ArticlePublisherPageModel : AbpPageModel
    {
        protected ArticlePublisherPageModel()
        {
            LocalizationResourceType = typeof(ArticlePublisherResource);
        }
    }
}