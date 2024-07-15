using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Cc.Data;

/* This is used if database provider does't define
 * ICcDbSchemaMigrator implementation.
 */
public class NullCcDbSchemaMigrator : ICcDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
