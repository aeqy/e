using Volo.Abp.Modularity;

namespace Cc;

[DependsOn(
    typeof(CcApplicationModule),
    typeof(CcDomainTestModule)
)]
public class CcApplicationTestModule : AbpModule
{

}
