using TestPlayWright.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TestPlayWright.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestPlayWrightMongoDbModule),
    typeof(TestPlayWrightApplicationContractsModule)
    )]
public class TestPlayWrightDbMigratorModule : AbpModule
{
}
