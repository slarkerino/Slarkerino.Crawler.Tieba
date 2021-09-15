using Volo.Abp.Modularity;

namespace Slarkerino.Crawler.Tieba
{
    [DependsOn(
        typeof(TiebaApplicationModule),
        typeof(TiebaDomainTestModule)
        )]
    public class TiebaApplicationTestModule : AbpModule
    {

    }
}