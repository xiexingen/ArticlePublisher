using Volo.Abp.Settings;

namespace XXG.ArticlePublisher.Settings
{
    public class ArticlePublisherSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ArticlePublisherSettings.MySetting1));
        }
    }
}
