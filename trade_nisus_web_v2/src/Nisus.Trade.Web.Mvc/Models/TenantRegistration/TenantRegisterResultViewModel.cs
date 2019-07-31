using Abp.AutoMapper;
using Nisus.Trade.MultiTenancy.Dto;

namespace Nisus.Trade.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}