using System.Threading.Tasks;

namespace Nisus.Trade.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}