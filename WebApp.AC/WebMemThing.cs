using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.AC
{
    public class MemoryThing
    {
        public MemoryThing()
        {
            var memthing = new MemoryCache(new MemoryCacheOptions());
        }
    }
}
