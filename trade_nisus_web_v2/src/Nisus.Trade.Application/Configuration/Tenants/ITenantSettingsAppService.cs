using System.Threading.Tasks;
using Abp.Application.Services;
using Nisus.Trade.Configuration.Tenants.Dto;

namespace Nisus.Trade.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
