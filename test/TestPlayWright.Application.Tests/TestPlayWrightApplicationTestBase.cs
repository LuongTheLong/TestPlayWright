using Volo.Abp.Modularity;

namespace TestPlayWright;

public abstract class TestPlayWrightApplicationTestBase<TStartupModule> : TestPlayWrightTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
