using System.Threading.Tasks;
using Abp.Dependency;

namespace Nisus.Trade.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}