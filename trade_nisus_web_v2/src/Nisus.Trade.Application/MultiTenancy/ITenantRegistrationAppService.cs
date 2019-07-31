using System.Threading.Tasks;
using Abp.Application.Services;
using Nisus.Trade.Editions.Dto;
using Nisus.Trade.MultiTenancy.Dto;

namespace Nisus.Trade.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}