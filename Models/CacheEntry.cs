using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace redisApi.Models
{
    public class CacheEntry
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}