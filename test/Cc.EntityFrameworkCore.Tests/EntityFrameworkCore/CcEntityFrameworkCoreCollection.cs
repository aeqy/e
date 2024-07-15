using Xunit;

namespace Cc.EntityFrameworkCore;

[CollectionDefinition(CcTestConsts.CollectionDefinitionName)]
public class CcEntityFrameworkCoreCollection : ICollectionFixture<CcEntityFrameworkCoreFixture>
{

}
