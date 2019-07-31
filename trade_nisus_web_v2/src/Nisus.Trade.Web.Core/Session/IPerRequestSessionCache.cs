using System.Threading.Tasks;
using Nisus.Trade.Sessions.Dto;

namespace Nisus.Trade.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
