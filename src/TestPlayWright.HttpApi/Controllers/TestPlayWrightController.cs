using TestPlayWright.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestPlayWright.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestPlayWrightController : AbpControllerBase
{
    protected TestPlayWrightController()
    {
        LocalizationResource = typeof(TestPlayWrightResource);
    }
}
