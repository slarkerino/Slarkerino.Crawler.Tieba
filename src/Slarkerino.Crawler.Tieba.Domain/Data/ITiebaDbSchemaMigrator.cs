using System.Threading.Tasks;

namespace Slarkerino.Crawler.Tieba.Data
{
    public interface ITiebaDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
