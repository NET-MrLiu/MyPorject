using Microsoft.Extensions.Configuration;

namespace Nisus.Trade.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
