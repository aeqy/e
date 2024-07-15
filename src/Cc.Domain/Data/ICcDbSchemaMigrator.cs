using System.Threading.Tasks;

namespace Cc.Data;

public interface ICcDbSchemaMigrator
{
    Task MigrateAsync();
}
