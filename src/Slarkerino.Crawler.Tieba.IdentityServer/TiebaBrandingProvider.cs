using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Slarkerino.Crawler.Tieba
{
    [Dependency(ReplaceServices = true)]
    public class TiebaBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Tieba";
    }
}
