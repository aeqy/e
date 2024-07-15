using Volo.Abp.Modularity;

namespace Cc;

public abstract class CcApplicationTestBase<TStartupModule> : CcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
