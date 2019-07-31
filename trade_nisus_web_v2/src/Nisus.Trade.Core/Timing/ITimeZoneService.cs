using System.Threading.Tasks;
using Abp.Configuration;

namespace Nisus.Trade.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
