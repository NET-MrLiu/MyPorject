using Abp.AutoMapper;
using Nisus.Trade.Editions;
using Nisus.Trade.MultiTenancy.Payments.Dto;

namespace Nisus.Trade.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}