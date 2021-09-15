using Volo.Abp.Settings;

namespace Slarkerino.Crawler.Tieba.Settings
{
    public class TiebaSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TiebaSettings.MySetting1));
        }
    }
}
