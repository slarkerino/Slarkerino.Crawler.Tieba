using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.SettingManagement;

namespace Slarkerino.Crawler.Tieba
{
    [DependsOn(
        typeof(TiebaApplicationContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule),
        typeof(AbpSettingManagementHttpApiClientModule)
    )]
    public class TiebaHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(TiebaApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
