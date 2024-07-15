using System;
using System.Collections.Generic;
using System.Text;
using Cc.Localization;
using Volo.Abp.Application.Services;

namespace Cc;

/* Inherit your application services from this class.
 */
public abstract class CcAppService : ApplicationService
{
    protected CcAppService()
    {
        LocalizationResource = typeof(CcResource);
    }
}
