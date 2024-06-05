using System;
using System.Collections.Generic;
using System.Text;
using TestPlayWright.Localization;
using Volo.Abp.Application.Services;

namespace TestPlayWright;

/* Inherit your application services from this class.
 */
public abstract class TestPlayWrightAppService : ApplicationService
{
    protected TestPlayWrightAppService()
    {
        LocalizationResource = typeof(TestPlayWrightResource);
    }
}
