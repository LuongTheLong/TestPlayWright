using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestPlayWright.Data;

/* This is used if database provider does't define
 * ITestPlayWrightDbSchemaMigrator implementation.
 */
public class NullTestPlayWrightDbSchemaMigrator : ITestPlayWrightDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
