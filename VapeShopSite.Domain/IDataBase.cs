using System.Threading.Tasks;
using VapeShopeSite.Domain.Models;

namespace VapeShopeSite.Application
{
    public interface IDataBase
    {
        Task<TestDomainEntity> Get(string id);
    }
}