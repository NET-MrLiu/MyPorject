using Abp.AutoMapper;
using Nisus.Trade.MultiTenancy.Payments;

namespace Nisus.Trade.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}