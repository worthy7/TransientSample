using Microsoft.Extensions.Caching.Memory;

namespace ConsoleApp.PR
{
    public class MemThing
    {
        public MemThing()
        {
            var memthing = new MemoryCache(new MemoryCacheOptions());
        }
    }
}
