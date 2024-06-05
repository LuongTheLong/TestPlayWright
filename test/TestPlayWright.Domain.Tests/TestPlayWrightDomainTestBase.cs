using Volo.Abp.Modularity;

namespace TestPlayWright;

/* Inherit from this class for your domain layer tests. */
public abstract class TestPlayWrightDomainTestBase<TStartupModule> : TestPlayWrightTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
