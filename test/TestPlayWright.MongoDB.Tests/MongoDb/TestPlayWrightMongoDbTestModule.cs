using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace TestPlayWright.MongoDB;

[DependsOn(
    typeof(TestPlayWrightApplicationTestModule),
    typeof(TestPlayWrightMongoDbModule)
)]
public class TestPlayWrightMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = TestPlayWrightMongoDbFixture.GetRandomConnectionString();
        });
    }
}
