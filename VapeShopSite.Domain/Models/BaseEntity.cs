using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VapeShopeSite.Application.Caching;
namespace VapeShopeSite.Application.Models
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public string EntityCacheKey => GetEntityCacheKey(GetType(), Id);

        public static string GetEntityCacheKey(Type type, string id)
        {
            return String.Format(CachingDefault.EntityCacheKey);
        }
    }
}
