using System.Threading.Tasks;
using Abp.Application.Services;
using Nisus.Trade.Sessions.Dto;

namespace Nisus.Trade.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
