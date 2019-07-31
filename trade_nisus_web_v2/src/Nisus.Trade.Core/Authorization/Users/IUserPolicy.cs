using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Nisus.Trade.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
