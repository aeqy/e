using Volo.Abp.Modularity;

namespace Cc;

[DependsOn(
    typeof(CcDomainModule),
    typeof(CcTestBaseModule)
)]
public class CcDomainTestModule : AbpModule
{

}
