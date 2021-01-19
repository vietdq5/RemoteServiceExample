using System.Threading.Tasks;

namespace RemoteServiceExample.Data
{
    public interface IRemoteServiceExampleDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
