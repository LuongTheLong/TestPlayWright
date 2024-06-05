using TestPlayWright.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TestPlayWright.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class TestPlayWrightPageModel : AbpPageModel
{
    protected TestPlayWrightPageModel()
    {
        LocalizationResourceType = typeof(TestPlayWrightResource);
    }
}
