using Cc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cc.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CcController : AbpControllerBase
{
    protected CcController()
    {
        LocalizationResource = typeof(CcResource);
    }
}
