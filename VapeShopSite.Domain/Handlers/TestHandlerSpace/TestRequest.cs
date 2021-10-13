using VapeShopeSite.Domain.Models;
using VapeShopSite.Common.Infrastructure;

namespace VapeShopeSite.Domain.Handlers.TestHandler
{
    public class TestRequest : IRequest<TestDomainEntity>
    {
        public string Id { get; set; }
    }
}