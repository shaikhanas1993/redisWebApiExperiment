using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using redisApi.Interfaces;
using StackExchange.Redis;

namespace redisApi.Services
{
    public class RedisDatabaseProvider : IRedisDatabaseProvider
    {
        
        private ConnectionMultiplexer _redisMultiplexer;

        public IDatabase GetDatabase()
        {
            if (_redisMultiplexer == null)
            {
                _redisMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            }

            return _redisMultiplexer.GetDatabase();

        }
    }
}