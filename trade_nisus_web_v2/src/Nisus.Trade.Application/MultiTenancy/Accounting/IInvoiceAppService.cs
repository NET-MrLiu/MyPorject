using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Nisus.Trade.MultiTenancy.Accounting.Dto;

namespace Nisus.Trade.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
