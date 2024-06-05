using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TestPlayWright.Web;

[Dependency(ReplaceServices = true)]
public class TestPlayWrightBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestPlayWright";
}
