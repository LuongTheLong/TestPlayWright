using System.Threading.Tasks;

namespace TestPlayWright.Data;

public interface ITestPlayWrightDbSchemaMigrator
{
    Task MigrateAsync();
}
