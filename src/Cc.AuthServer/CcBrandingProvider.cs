using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Cc;

[Dependency(ReplaceServices = true)]
public class CcBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Cc";
}
