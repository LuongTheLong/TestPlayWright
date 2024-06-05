using Volo.Abp.Modularity;

namespace TestPlayWright;

[DependsOn(
    typeof(TestPlayWrightApplicationModule),
    typeof(TestPlayWrightDomainTestModule)
)]
public class TestPlayWrightApplicationTestModule : AbpModule
{

}
