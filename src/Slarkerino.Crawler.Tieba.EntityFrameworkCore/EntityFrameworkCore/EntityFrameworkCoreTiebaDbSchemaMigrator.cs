using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Slarkerino.Crawler.Tieba.Data;
using Volo.Abp.DependencyInjection;

namespace Slarkerino.Crawler.Tieba.EntityFrameworkCore
{
    public class EntityFrameworkCoreTiebaDbSchemaMigrator
        : ITiebaDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTiebaDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TiebaDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TiebaDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
