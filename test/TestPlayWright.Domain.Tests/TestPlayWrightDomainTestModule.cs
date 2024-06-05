using Volo.Abp.Modularity;

namespace TestPlayWright;

[DependsOn(
    typeof(TestPlayWrightDomainModule),
    typeof(TestPlayWrightTestBaseModule)
)]
public class TestPlayWrightDomainTestModule : AbpModule
{

}
