using Slarkerino.Crawler.Tieba.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Slarkerino.Crawler.Tieba.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TiebaEntityFrameworkCoreModule),
        typeof(TiebaApplicationContractsModule)
        )]
    public class TiebaDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
