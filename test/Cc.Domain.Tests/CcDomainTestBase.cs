using Volo.Abp.Modularity;

namespace Cc;

/* Inherit from this class for your domain layer tests. */
public abstract class CcDomainTestBase<TStartupModule> : CcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
