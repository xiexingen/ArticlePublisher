using System;
using System.Collections.Generic;
using System.Text;
using XXG.ArticlePublisher.Localization;
using Volo.Abp.Application.Services;

namespace XXG.ArticlePublisher
{
    /* Inherit your application services from this class.
     */
    public abstract class ArticlePublisherAppService : ApplicationService
    {
        protected ArticlePublisherAppService()
        {
            LocalizationResource = typeof(ArticlePublisherResource);
        }
    }
}
