using System.Threading.Tasks;
using Abp.Application.Services;

namespace Nisus.Trade.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
