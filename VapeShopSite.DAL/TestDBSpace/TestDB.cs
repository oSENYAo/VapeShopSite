using System.Threading.Tasks;
using VapeShopeSite.Application;
using VapeShopeSite.Domain.Models;

namespace VapeShopeSite.DAL.TestDBSpace
{
    public class TestDB : IDataBase
    {
        public Task<TestDomainEntity> Get(string id)
        {
            return Task.FromResult(new TestDomainEntity() { Result = "HELLO" });
        }

    }
}