using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace XXG.ArticlePublisher.EntityFrameworkCore
{
    public static class ArticlePublisherDbContextModelCreatingExtensions
    {
        public static void ConfigureArticlePublisher(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ArticlePublisherConsts.DbTablePrefix + "YourEntities", ArticlePublisherConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}