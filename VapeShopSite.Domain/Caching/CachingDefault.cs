using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapeShopeSite.Application.Caching
{
    public static partial class CachingDefault
    {
        public static int CacheTime => 60;
        public static string EntityCacheKey => "Nop.{0}.id-{1}";
    }
}
