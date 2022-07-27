using Microsoft.Extensions.Caching.Memory;

namespace ConsoleApp.AC
{
    public class MemThing
    {
        public MemThing()
        {
            var memthing = new MemoryCache(new MemoryCacheOptions());
        }
    }
}
