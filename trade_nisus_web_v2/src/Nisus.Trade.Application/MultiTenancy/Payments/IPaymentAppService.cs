using System.Threading.Tasks;
using Abp.Application.Services;
using Nisus.Trade.MultiTenancy.Dto;
using Nisus.Trade.MultiTenancy.Payments.Dto;
using Abp.Application.Services.Dto;

namespace Nisus.Trade.MultiTenancy.Payments
{
    public interface IPaymentAppService : IApplicationService
    {
        Task<PaymentInfoDto> GetPaymentInfo(PaymentInfoInput input);

        Task<CreatePaymentResponse> CreatePayment(CreatePaymentDto input);

        Task<ExecutePaymentResponse> ExecutePayment(ExecutePaymentDto input);

        Task<PagedResultDto<SubscriptionPaymentListDto>> GetPaymentHistory(GetPaymentHistoryInput input);
    }
}
