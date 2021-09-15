using Slarkerino.Crawler.Tieba.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Slarkerino.Crawler.Tieba
{
    [DependsOn(
        typeof(TiebaEntityFrameworkCoreTestModule)
        )]
    public class TiebaDomainTestModule : AbpModule
    {

    }
}