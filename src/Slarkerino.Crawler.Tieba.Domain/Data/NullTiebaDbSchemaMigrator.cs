using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Slarkerino.Crawler.Tieba.Data
{
    /* This is used if database provider does't define
     * ITiebaDbSchemaMigrator implementation.
     */
    public class NullTiebaDbSchemaMigrator : ITiebaDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}