using Slarkerino.Crawler.Tieba.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Slarkerino.Crawler.Tieba
{
    [DependsOn(
        typeof(AbpAuditLoggingDomainSharedModule),
        typeof(AbpBackgroundJobsDomainSharedModule),
        typeof(AbpFeatureManagementDomainSharedModule),
        typeof(AbpIdentityDomainSharedModule),
        typeof(AbpIdentityServerDomainSharedModule),
        typeof(AbpPermissionManagementDomainSharedModule),
        typeof(AbpSettingManagementDomainSharedModule),
        typeof(AbpTenantManagementDomainSharedModule)
        )]
    public class TiebaDomainSharedModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            TiebaGlobalFeatureConfigurator.Configure();
            TiebaModuleExtensionConfigurator.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<TiebaDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<TiebaResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Tieba");

                options.DefaultResourceType = typeof(TiebaResource);
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Tieba", typeof(TiebaResource));
            });
        }
    }
}
