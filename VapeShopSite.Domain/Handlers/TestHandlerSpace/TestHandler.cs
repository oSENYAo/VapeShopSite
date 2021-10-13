using System.Threading.Tasks;
using VapeShopeSite.Application;
using VapeShopeSite.Domain.Handlers.TestHandler;
using VapeShopeSite.Domain.Models;
using VapeShopSite.Common.Infrastructure;

namespace VapeShopeSite.Domain.Handlers.TestHandlerSpace
{
    public class TestHandler : IRequestHandler<TestRequest, TestDomainEntity>
    {
        private readonly IDataBase _db;

        public TestHandler(IDataBase db)
        {
            _db = db;
        }
        public Task<TestDomainEntity> HandleAsync(TestRequest request)
        {
            return _db.Get(request.Id);
        }
    }
}